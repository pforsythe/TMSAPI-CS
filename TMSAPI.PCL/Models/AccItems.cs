/*
 * TMSAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 12/20/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TMSAPI.PCL;
using TMSAPI.PCL.Utilities;

namespace TMSAPI.PCL.Models
{
    public class AccItems : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private List<AccItem> accItem;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AccItem")]
        public List<AccItem> AccItem 
        { 
            get 
            {
                return this.accItem; 
            } 
            set 
            {
                this.accItem = value;
                onPropertyChanged("AccItem");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 