using System;

namespace UC11SortByPersonName
{
    public interface IAddressBook
    {
        void AddOrAccessAddressBook();
        void ViewAllAddressBooks();
        void DeleteAddressBook();
    }
   public class Program
    {
       
           public const string TO_ADD_OR_ACCESS = "a";
        public const string TO_VIEW_ALL_ADDRESSBOOKS = "view";
        public const string TO_DELETE_ADDRESS_BOOK = "delete";
        public const string SEARCH_PERSON_IN_CITY = "city";
        public const string SEARCH_PERSON_IN_STATE = "state";
        public const string VIEW_ALL_IN_CITY = "vcity";
        public const string VIEW_ALL_IN_STATE = "vstate";
        public const string COUNT_ALL_IN_CITY = "ccity";
        public const string COUNT_ALL_IN_STATE = "cstate";
        public const string EXIT = "e";
          
    }
}
