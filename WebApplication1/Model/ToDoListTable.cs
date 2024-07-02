using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model;
public class ToDoListTable {

    public int Id { get; set; }

    [StringLength(80)]
    public string Description { get; set; }


    [StringLength(80)]
    public string Status { get; set; } = "Active";


    public DateTime DueDate { get; set; }


    [StringLength(80)]
    public string Priority { get; set; } = "Medium";




}