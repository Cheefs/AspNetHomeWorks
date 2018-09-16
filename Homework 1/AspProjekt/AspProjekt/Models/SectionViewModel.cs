using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Domain.Models.Base;

namespace AspProjekt.Models
{
    public class SectionViewModel : INameEntity, IOrderEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<SectionViewModel> ChildSections { get; set; }

        public SectionViewModel ParentSection { get; set; }
    }
}
