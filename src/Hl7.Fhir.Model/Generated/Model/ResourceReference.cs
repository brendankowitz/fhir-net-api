﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011-2013, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Thu, Apr 24, 2014 12:29+0200 for FHIR v0.80
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A reference from one resource to another
    /// </summary>
    [FhirType("ResourceReference")]
    [DataContract]
    public partial class ResourceReference : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Relative, internal or absolute URL reference
        /// </summary>
        [FhirElement("reference", InSummary=true, Order=40)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ReferenceElement
        {
            get { return _ReferenceElement; }
            set { _ReferenceElement = value; OnPropertyChanged("ReferenceElement"); }
        }
        private Hl7.Fhir.Model.FhirString _ReferenceElement;
        
        /// <summary>
        /// Relative, internal or absolute URL reference
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Reference
        {
            get { return ReferenceElement != null ? ReferenceElement.Value : null; }
            set
            {
                if(value == null)
                  ReferenceElement = null; 
                else
                  ReferenceElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Reference");
            }
        }
        
        /// <summary>
        /// Text alternative for the resource
        /// </summary>
        [FhirElement("display", InSummary=true, Order=50)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DisplayElement
        {
            get { return _DisplayElement; }
            set { _DisplayElement = value; OnPropertyChanged("DisplayElement"); }
        }
        private Hl7.Fhir.Model.FhirString _DisplayElement;
        
        /// <summary>
        /// Text alternative for the resource
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Display
        {
            get { return DisplayElement != null ? DisplayElement.Value : null; }
            set
            {
                if(value == null)
                  DisplayElement = null; 
                else
                  DisplayElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Display");
            }
        }
        
    }
    
}
