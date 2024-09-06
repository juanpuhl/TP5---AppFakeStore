﻿namespace AppFakeStore.Models
{
    public class Geolocation
    {
        public string lat { get; set; }
        public string @long { get; set; }
    }

    public class Address
    {
        public Geolocation geolocation { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string zipcode { get; set; }
    }

    public class Name
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }

    public class Usuario
    {
        public Address address { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Name name { get; set; } // Esta propiedad ahora es accesible directamente
        public string phone { get; set; }
        public int __v { get; set; }
      
    }
}
