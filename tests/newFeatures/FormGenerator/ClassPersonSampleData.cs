using System;
using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;

namespace Lamedal_UIWinForms.Test.newFeatures.FormGenerator
{
    [BlueprintData_Table(true)]
    public class ClassPersonSampleData
    {
        public int Id;
        public string Name;
        public DateTime BerthDate;
        public enPeople_SexIndex SexIndex;
        public enPeople_TitleSimple Title;
        public int Age;
    }
}
