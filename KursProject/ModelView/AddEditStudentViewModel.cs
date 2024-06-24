using KursProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.ModelView
{
    class AddEditStudentViewModel : BaseClass
    {
        public IList<University> Universities { get; } = new ObservableCollection<University>();

        public AddEditStudentViewModel()
        {
            using (UchebContext db = new UchebContext())
            {
                Universities = db.Universities.ToList();
            }
        }
    }
}
