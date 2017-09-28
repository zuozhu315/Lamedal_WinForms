using System;
using LamedalCore.domain.Attributes;

namespace Lamedal_UIWinForms.Test.newFeatures.People
{
    [BlueprintData_Table(true)]
    public class ClassPersonSampleData
    {
        public int Id;
        public string Name;
        public DateTime BerthDate;
        public enPeopleSexIndex SexIndex;
        public enPeopleTitle Title;
        public int Age;
    }
}
