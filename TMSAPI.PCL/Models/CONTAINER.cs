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
    public class CONTAINER : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string cONTAINERID;
        private string dESCRIPTION;

        /// <summary>
        /// Id of Container type
        /// </summary>
        [JsonProperty("CONTAINER_ID")]
        public string CONTAINERID 
        { 
            get 
            {
                return this.cONTAINERID; 
            } 
            set 
            {
                this.cONTAINERID = value;
                onPropertyChanged("CONTAINERID");
            }
        }

        /// <summary>
        /// Description of Container Type
        /// </summary>
        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION 
        { 
            get 
            {
                return this.dESCRIPTION; 
            } 
            set 
            {
                this.dESCRIPTION = value;
                onPropertyChanged("DESCRIPTION");
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