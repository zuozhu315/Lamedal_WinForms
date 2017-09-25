using LamedalCore.domain.Attributes;

namespace Lamedal_UIWinForms.domain.Enumerals
{
    public enum enForm_Size
    {
        [enumInt(150)]
        Tiny,

        [enumInt(300)]
        Small,
        
        [enumInt(450)]
        Medium,

        [enumInt(600)]
        Big,

        [enumInt(800)]
        Huge,

        Manual
    }
}