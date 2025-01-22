using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebQuery.Models
{
    public class Status
    {
        //SelectListeItem type list creating Dropdown 
        public IEnumerable<SelectListItem>? EmpList { get; set; }

        //for first dropdown selected value
        public string? SelectedEmp { get; set; }

        //for second dropdown selected value
        public string? SelectedEmp2 { get; set; }

    }
}
