using UnityEngine;
using System;
using System.Globalization;

public class CreateTask : MonoBehaviour {

    private int priority;
    private string title;
    private string due;
    private int icon;

    public TaskManager taskManager;

    public void Create() {
        //CHECKS!

        DateTime date = DateTime.ParseExact(due, "dd/MM/yy", CultureInfo.InvariantCulture);
        taskManager.addTask(new Task(title, icon, date, priority));
    }

    public void setPriority(int p) {
        priority = p;
    }

    public void setIcon(int i) {
        icon = i;
    }

    public void setDue(string d) {
        due = d;
    }

    public void setTitle(string t) {
        title = t;
    }
}
