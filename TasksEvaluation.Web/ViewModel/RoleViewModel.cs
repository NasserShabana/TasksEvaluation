﻿namespace TasksEvaluation.Web.ViewModel
{
    public class RoleViewModel
    {
        public string id {  get; set; }      
       
       public string RoleName { get; set; }
    
     public RoleViewModel() 
        { 
         id = Guid.NewGuid().ToString();
        }

    }
}
