using Notatki.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notatki {
    public partial class MainPage : ContentPage {
        ObservableCollection<NoteModel> list = new ObservableCollection<NoteModel>();
        public MainPage() {
            InitializeComponent();
            list=new ObservableCollection<NoteModel>() {
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

        private void Add_Clicked(object sender, EventArgs e)
        {
            NoteModel noteModel = new NoteModel()
            {
                ID=Guid.NewGuid(),
                Title=TitleEntry.Text,
                Description=DescriptonEntry.Text,
            };
            list.Add(noteModel);
        }
    }
}
