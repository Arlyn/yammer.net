﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections;

namespace Yammer
{
    [DataContract(Name="message")]
    [XmlRoot(ElementName="message")]
    public class Message 
    {
        public Message()
        {
        }

        #region Yammer Properties

        /// <summary>
        /// The ID number for this object. Note that IDs are not unique across all object types: 
        /// there may be a user and tag with the same numerical ID.
        /// </summary>
        [DataMember(Name="id")]
        [XmlElement(ElementName="id")]
        public string Id { get; set; }

        /// <summary>
        /// (Optional) When a message is posted into a group, that group's ID will appear here 
        /// and the group will be available in the references section.
        /// </summary>
        [DataMember(Name="group-id")]
        [XmlElement(ElementName="group-id")]
        public string GroupId { get; set; }

        /// <summary>
        /// (Optional) When a message is a private 1-to-1 (or "direct") message, this will 
        /// indicate the intended recipient.
        /// </summary>
        [DataMember(Name="direct-to-id")]
        [XmlElement(ElementName="direct-to-id")]
        public string DirectToId { get; set; }

        /// <summary>
        /// The API resource for fetching this object.
        /// </summary>
        [DataMember(Name="url")]
        [XmlElement(ElementName="url")]
        public string Url { get; set; }

        /// <summary>
        /// The URL for viewing this object on the main Yammer website.
        /// </summary>
        [DataMember(Name="web-url")]
        [XmlElement(ElementName="web-url")]
        public string WebUrl { get; set; }

        /// <summary>
        /// The ID of the message this message is in reply to, if applicable.
        /// </summary>
        [DataMember(Name="replied-to-id")]
        [XmlElement(ElementName="replied-to-id")]
        public string RepliedToId { get; set; }

        /// <summary>
        /// The thread in which this message appears.
        /// </summary>
        [DataMember(Name="thread-id")]
        [XmlElement(ElementName="thread-id")]
        public string ThreadId { get; set; }

        /// <summary>
        /// Message body
        /// </summary>
        [DataMember(Name="body")]
        [XmlElement(ElementName="body")]
        public Body Body { get; set; }

        /// <summary>
        /// A list of attachments for this message.
        /// </summary>
        [DataMember(Name="attachments")]         
        [System.Xml.Serialization.XmlArray("attachments")]
        [System.Xml.Serialization.XmlArrayItem("attachment", typeof(Attachment))]
        public List<Attachment> Attachments { get; set; }
        
        /// <summary>
        /// This will be system or update. A system message is automatically generated by the 
        /// system and describes an action, such as "Kris Gale has joined the Geni network." 
        /// An update message is a regular message posted by a user such as "Kris Gale: Hi everyone." 
        /// Put simply, this indicates whether a colon will separate the body of the message 
        /// from the sender's name in the web interface.
        /// </summary>
        [DataMember(Name="message-type")]
        [XmlElement(ElementName="message-type")]
        public string MessageType { get; set; }


        [DataMember(Name="client-type")]
        [XmlElement(ElementName="client-type")]
        public string ClientType { get; set; }
        /// <summary>
        /// The ID of the message's sender.
        /// </summary>
        [DataMember(Name="sender-id")]
        [XmlElement(ElementName="sender-id")]
        public int SenderId { get; set; }

        /// <summary>
        /// The sender's object type: user or guide. The guide is virtual user that exists 
        /// in the system to send messages such as the tips and initial welcome message.
        /// </summary>
        [DataMember(Name="sender-type")]
        [XmlElement(ElementName="sender-type")]
        public string SenderType { get; set; }

        /// <summary>
        /// The time and date this resource was created. This would indicate when a 
        /// user joined the network or when a message was posted.
        /// </summary>
        [DataMember(Name="created-at")]
        [XmlElement(ElementName="created-at")]
        public string CreatedAt { get; set; }

        [XmlIgnore]
        public string Participants { get; set; }



        #endregion

        #region Client Properties

        public Reference References { get; set; }


        #endregion
    }
}

