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
    public class SHIPMENTSTOP : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int sTOPID;
        private int sTOPSEQNUMBER;
        private STOPTYPEEnum sTOPTYPE;
        private string nAME;
        private string aDDRESS1;
        private string cITY;
        private string sTATE;
        private int pOSTALCODE;
        private string cOUNTRY;
        private string cONTACTNAME;
        private int cONTACTPHONE;
        private int? cONTACTFAX;
        private string aDDRESS2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("STOP_ID")]
        public int STOPID 
        { 
            get 
            {
                return this.sTOPID; 
            } 
            set 
            {
                this.sTOPID = value;
                onPropertyChanged("STOPID");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("STOP_SEQ_NUMBER")]
        public int STOPSEQNUMBER 
        { 
            get 
            {
                return this.sTOPSEQNUMBER; 
            } 
            set 
            {
                this.sTOPSEQNUMBER = value;
                onPropertyChanged("STOPSEQNUMBER");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("STOP_TYPE", ItemConverterType = typeof(StringValuedEnumConverter))]
        public STOPTYPEEnum STOPTYPE 
        { 
            get 
            {
                return this.sTOPTYPE; 
            } 
            set 
            {
                this.sTOPTYPE = value;
                onPropertyChanged("STOPTYPE");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("NAME")]
        public string NAME 
        { 
            get 
            {
                return this.nAME; 
            } 
            set 
            {
                this.nAME = value;
                onPropertyChanged("NAME");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ADDRESS_1")]
        public string ADDRESS1 
        { 
            get 
            {
                return this.aDDRESS1; 
            } 
            set 
            {
                this.aDDRESS1 = value;
                onPropertyChanged("ADDRESS1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CITY")]
        public string CITY 
        { 
            get 
            {
                return this.cITY; 
            } 
            set 
            {
                this.cITY = value;
                onPropertyChanged("CITY");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("STATE")]
        public string STATE 
        { 
            get 
            {
                return this.sTATE; 
            } 
            set 
            {
                this.sTATE = value;
                onPropertyChanged("STATE");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("POSTAL_CODE")]
        public int POSTALCODE 
        { 
            get 
            {
                return this.pOSTALCODE; 
            } 
            set 
            {
                this.pOSTALCODE = value;
                onPropertyChanged("POSTALCODE");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("COUNTRY")]
        public string COUNTRY 
        { 
            get 
            {
                return this.cOUNTRY; 
            } 
            set 
            {
                this.cOUNTRY = value;
                onPropertyChanged("COUNTRY");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CONTACT_NAME")]
        public string CONTACTNAME 
        { 
            get 
            {
                return this.cONTACTNAME; 
            } 
            set 
            {
                this.cONTACTNAME = value;
                onPropertyChanged("CONTACTNAME");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CONTACT_PHONE")]
        public int CONTACTPHONE 
        { 
            get 
            {
                return this.cONTACTPHONE; 
            } 
            set 
            {
                this.cONTACTPHONE = value;
                onPropertyChanged("CONTACTPHONE");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CONTACT_FAX")]
        public int? CONTACTFAX 
        { 
            get 
            {
                return this.cONTACTFAX; 
            } 
            set 
            {
                this.cONTACTFAX = value;
                onPropertyChanged("CONTACTFAX");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ADDRESS_2")]
        public string ADDRESS2 
        { 
            get 
            {
                return this.aDDRESS2; 
            } 
            set 
            {
                this.aDDRESS2 = value;
                onPropertyChanged("ADDRESS2");
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