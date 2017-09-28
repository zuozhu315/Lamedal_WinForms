using System;

namespace Lamedal_UIWinForms.Test.temp
{
    [Flags]
    public enum enPeopleLanguageRSA
    {
        Afrikaans,
        English,
        IsiZulu, isiXhosa, siSwati, isiNdebele,
        Nguni = IsiZulu+ isiXhosa+ siSwati+ isiNdebele,
        Sepedi_NorthernSotho, Sesotho_SouthernSotho, Setswana_Tswana,
        Sotho_Tswana = Sepedi_NorthernSotho + Sesotho_SouthernSotho + Setswana_Tswana,
        Venda, Tsonga,
        Xhosa,
        Zulu
    }
}