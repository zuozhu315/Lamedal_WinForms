using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using LamedalCore.domain.Attributes;

namespace Lamedal_UIWinForms.Test.temp
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
