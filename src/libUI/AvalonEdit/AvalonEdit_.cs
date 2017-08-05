using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;

namespace Lamedal_UIWinForms.libUI.AvalonEdit
{
    public sealed class AvalonEdit_
    {
        private FoldingManager _foldingManager;

        /// <summary>
        /// Setup the foldings of the text editor.
        /// </summary>
        /// <param name="textEditor">The text editor</param>
        public void TextEditor_Foldings(TextEditor textEditor)
        {
            if (_foldingManager != null) FoldingManager.Uninstall(_foldingManager);
            
            _foldingManager = FoldingManager.Install(textEditor.TextArea);
            var foldingStrategy = new AvalonEdit_BraceFoldingStrategy();
            foldingStrategy.UpdateFoldings(_foldingManager, textEditor.Document);
        }

        /// <summary>
        /// Highlight c# code in the  text editor.
        /// </summary>
        /// <param name="textEditor">The text editor</param>
        public void TextEditor_Highlight(TextEditor textEditor)
        {
            IHighlightingDefinition highlightCSharp = HighlightingManager.Instance.GetDefinition("C#");
            textEditor.SyntaxHighlighting = highlightCSharp;
        }

        /// <summary>
        /// Set options for the text editor.
        /// </summary>
        /// <param name="textEditor">The text editor.</param>
        /// <param name="showLineNumbers">Show line numbers indicator. Default value = true.</param>
        /// <param name="showColumnRuler">Show column ruler indicator. Default value = true.</param>
        /// <param name="indentationSize">The indentation size setting. Default value = 2.</param>
        /// <param name="fontName">The font name setting. Default value = "Consolas".</param>
        /// <param name="fontSize">The font size setting. Default value = 12.</param>
        public void TextEditor_Options(TextEditor textEditor, bool showLineNumbers = true, bool showColumnRuler = true, int indentationSize = 2,
                    string fontName = "Arial Narrow", int fontSize = 12)
        {
            textEditor.ShowLineNumbers = showLineNumbers;
            //_textEditor.Background = Brushes.LightGreen;
            textEditor.Options.ShowColumnRuler = showColumnRuler;
            textEditor.Options.IndentationSize = indentationSize;
            textEditor.FontFamily = new System.Windows.Media.FontFamily(fontName);
            textEditor.FontSize = fontSize;
        }

        /// <summary>
        /// Function to creates the text editor.
        /// </summary>
        /// <param name="parentControl">The parent control.</param>
        /// <param name="host">The host panel.</param>
        public TextEditor TextEditor_Create(ContainerControl parentControl, ElementHost host)
        {
            var textEditor = new TextEditor();
            host.Child = textEditor;
            parentControl.Controls.Add(host);
            return textEditor;
        }
    }
}
