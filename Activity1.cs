using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CarListExercise
{
    [Activity(Label = "Activity1")]
    public class Activity1 : ListActivity
    {
        List<CarInfo> _items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _items = new List<CarInfo>()
            {
                new CarInfo(){Manufacturer = "Alfa Romeo",Model = "GT Distinctive",Year = "2007" ,kW = "110kW"},
                new CarInfo(){Manufacturer = "Alfa Romeo",Model = "GTV",Year = "2003" ,kW = "110kW" },
                new CarInfo(){Manufacturer = "Alfa Romeo",Model = "GT JTS",Year = "2004" ,kW = "122kW" },
                new CarInfo(){Manufacturer = "Audi",Model = "A6 allroad",Year = "2000" ,kW = "132kW" },
                new CarInfo(){Manufacturer = "Audi",Model = "A4 B5",Year = "1998" ,kW = "74kW" },
                new CarInfo(){Manufacturer = "BMW",Model = "320",Year = "2002" ,kW = "110kW" },
                new CarInfo(){Manufacturer = "BMW",Model = "730",Year = "2003" ,kW = "160kW" },
                new CarInfo(){Manufacturer = "Ford",Model = "Focus",Year = "2001" ,kW = "85kW" },
                new CarInfo(){Manufacturer = "Nissan",Model = "Almera",Year = "2006" ,kW = "85kW" },
                new CarInfo(){Manufacturer = "Volvo",Model = "C70",Year = "1999" ,kW = "142kW" }
            };

            //var listview = FindViewById<ListView>(Resource.Id.listView1);
            //listview.Adapter = new BasicAdapter(this, _items);
        }
    }
}