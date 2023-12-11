using Notatki.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notatki {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            List<NoteModel> list=new List<NoteModel>() {
                new NoteModel() {
                    ID=Guid.NewGuid(),
                    Title="123",
                    Description="123",
                },
                new NoteModel() {
                    ID=Guid.NewGuid(),
                    Title="4232",
                    Description="123",
                }
            };

            Lista.ItemsSource= list;
        }
    }
}
