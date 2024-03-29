﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Restaurant
    {
        private readonly List<string> m_customers = new List<string>();
        public event Action<string> NewCustomer; 
        public void AddCustomer( string a_customerName )
        {
            m_customers.Add( a_customerName );
            NewCustomer?.Invoke( a_customerName );
        }
    }
    
    public class Reception
    {
        public void ChargeWaiter( string a_customerName )
        {
            Console.WriteLine( $"Charged a waiter for {a_customerName}" );
        }
    }

    public class Table
    {
        public void BookTable( string a_customerName )
        {
            Console.WriteLine( $"{ a_customerName} booked a table" );
        }
    }


}
