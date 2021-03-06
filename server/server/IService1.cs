﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        void registeruser(string username, string password);

        [OperationContract]
        void registeradmin(string username, string password);


        [OperationContract]
        bool Login_user(string username, string password);

        [OperationContract]
        bool isadmin(string usernmae, string password);

        [OperationContract]
        void addpost(string title, string category, string description);

        [OperationContract]
        Post getpost(int postID);

        [OperationContract]
        List<Post> getPendingpostlist();

        [OperationContract]
        void postingthepost(Post p);

        [OperationContract]
        List<Post> getLogPendingPosts();

        [OperationContract]
        List<Post> getapprovedpost();

        [OperationContract]
        void approvePost(string id);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
