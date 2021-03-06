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
    public class Container : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string containerId;
        private string description;

        /// <summary>
        /// Id of Container type
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId 
        { 
            get 
            {
                return this.containerId; 
            } 
            set 
            {
                this.containerId = value;
                onPropertyChanged("ContainerId");
            }
        }

        /// <summary>
        /// Description of Container Type
        /// </summary>
        [JsonProperty("Description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
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