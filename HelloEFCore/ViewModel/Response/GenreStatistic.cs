using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEFCore.ViewModel.Response
{
    public class GenreStatistic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalPost { get; set; }
    }
}
