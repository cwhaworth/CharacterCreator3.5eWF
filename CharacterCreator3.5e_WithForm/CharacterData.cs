using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator3._5e_WithForm
{
    class CharacterData
    {
        public CharacterData(){}

        public DataTable GetRaces()
        {
            DataTable races = new DataTable();
            DataColumn column = new DataColumn();
            DataRow row;            

            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "RaceName";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FavoriteClass";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Size";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Speed";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AdjustStr";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AdjustDex";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AdjustCon";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AdjustInt";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AdjustWis";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "AdjustCha";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            races.Columns.Add(column);

            //Investigate a column for array type for bonus languages

            row = races.NewRow();
            row["id"] = 100;
            row["RaceName"] = "Dwarf";
            row["FavoriteClass"] = "Fighter";
            row["Size"] = "Medium";
            row["Speed"] = 20;
            row["AdjustStr"] = 0;
            row["AdjustDex"] = 0;
            row["AdjustCon"] = 2;
            row["AdjustInt"] = 0;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = -2;
            races.Rows.Add(row);

            row = races.NewRow();
            row["id"] = 101;
            row["RaceName"] = "Elf";
            row["FavoriteClass"] = "Wizard";
            row["Size"] = "Medium";
            row["Speed"] = 30;
            row["AdjustStr"] = 0;
            row["AdjustDex"] = 2;
            row["AdjustCon"] = -2;
            row["AdjustInt"] = 0;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = 0;
            races.Rows.Add(row);

            row = races.NewRow();
            row["id"] = 102;
            row["RaceName"] = "Gnome";
            row["FavoriteClass"] = "Bard";
            row["Size"] = "Medium";
            row["Speed"] = 20;
            row["AdjustStr"] = -2;
            row["AdjustDex"] = 0;
            row["AdjustCon"] = 2;
            row["AdjustInt"] = 0;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = 0;
            races.Rows.Add(row);

            row = races.NewRow();
            row["id"] = 103;
            row["RaceName"] = "Halfling";
            row["FavoriteClass"] = "Rogue";
            row["Size"] = "Medium";
            row["Speed"] = 20;
            row["AdjustStr"] = -2;
            row["AdjustDex"] = 2;
            row["AdjustCon"] = 0;
            row["AdjustInt"] = 0;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = 0;
            races.Rows.Add(row);

            row = races.NewRow();
            row["id"] = 104;
            row["RaceName"] = "Half-elf";
            row["FavoriteClass"] = "Any";
            row["Size"] = "Medium";
            row["Speed"] = 30;
            row["AdjustStr"] = 0;
            row["AdjustDex"] = 0;
            row["AdjustCon"] = 0;
            row["AdjustInt"] = 0;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = 0;
            races.Rows.Add(row);

            row = races.NewRow();
            row["id"] = 105;
            row["RaceName"] = "Half-orc";
            row["FavoriteClass"] = "Barbarian";
            row["Size"] = "Medium";
            row["Speed"] = 30;
            row["AdjustStr"] = 2;
            row["AdjustDex"] = 0;
            row["AdjustCon"] = 0;
            row["AdjustInt"] = -2;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = -2;
            races.Rows.Add(row);

            row = races.NewRow();
            row["id"] = 106;
            row["RaceName"] = "Human";
            row["FavoriteClass"] = "Any";
            row["Size"] = "Medium";
            row["Speed"] = 30;
            row["AdjustStr"] = 0;
            row["AdjustDex"] = 0;
            row["AdjustCon"] = 0;
            row["AdjustInt"] = 0;
            row["AdjustWis"] = 0;
            row["AdjustCha"] = 0;
            races.Rows.Add(row);

            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = races.Columns["id"];
            races.PrimaryKey = PrimaryKeyColumns;
            races.TableName = "Races";

            return races;
        }
    }
}
