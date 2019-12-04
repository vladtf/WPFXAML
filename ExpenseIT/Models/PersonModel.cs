﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseIT.Models
{
    /// <summary>
    /// The data about person we want to get from database.
    /// </summary>
    class PersonModel
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        public string first_name { get; set; }

        /// <summary>
        /// The user's last name.
        /// </summary>
        public string last_name { get; set; }
        /// <summary>
        /// The user's email.
        /// </summary>
        public string email { get; set; }

        public string FullName
        {
            get 
            {
                return (string)$"{first_name} {last_name}";
            }
        }

    }
}
