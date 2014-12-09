/*
 * Clarify.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 10/06/2014
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
using Clarify.PCL;

namespace Clarify.PCL.Models
{
    public class ItemResultModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int score;
        private List<TermResultModel> termResults;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("score")]
        public int Score 
        { 
            get 
            {
                return this.score; 
            } 
            set 
            {
                this.score = value;
                onPropertyChanged("Score");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("term_results")]
        public List<TermResultModel> TermResults 
        { 
            get 
            {
                return this.termResults; 
            } 
            set 
            {
                this.termResults = value;
                onPropertyChanged("TermResults");
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