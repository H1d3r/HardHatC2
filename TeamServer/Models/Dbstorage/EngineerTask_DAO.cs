﻿using System.Collections.Generic;
using SQLite; 


namespace TeamServer.Models.Dbstorage
{
    [Table("EngineerTask")]
    public class EngineerTask_DAO
    {
        [PrimaryKey]
        public string Id { get; set; }

        [Column("Command")]
        public string CommandHeader { get; set; }

        //create an implicit operator to convert from the model to the doa
        public static implicit operator EngineerTask_DAO(EngineerTask model)
        {
            return new EngineerTask_DAO
            {
                Id = model.Id,
                CommandHeader = model.Command
            };
        }


        //create an implicit operator to convert from the doa to the model
        public static implicit operator EngineerTask(EngineerTask_DAO dao)
        {
            return new EngineerTask
            {
                Id = dao.Id,
                Command = dao.CommandHeader
            };
        }
    }



}