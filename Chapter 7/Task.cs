using UnityEngine;
using System.Collections;
using System;

public class Task {

    public string title;
    public int icon;
    public int priority;
    public DateTime expireDate;

    public bool isCompleted;
    

    public bool isExpired() {
        if(DateTime.Now > expireDate) {
            return true;
        }
        else {
            return false;
        }
    }

    public string Status() {
        if (isCompleted) {
            return "Completed";
        } else if(DateTime.Now > expireDate) {
            return "Expired";
        }
        return "Pending";
    }

    public Task (string _title, int _icon, DateTime _expireDate) {
        title = _title;
        icon = _icon;
        expireDate = _expireDate;
    }

    public Task(string _title, int _icon, DateTime _expireDate, int _priority) {
        title = _title;
        icon = _icon;
        expireDate = _expireDate;
        priority = _priority;
    }

    public Task() {

    }

    public Task(string _title) {
        title = _title;
    }

    public override string ToString() {
        return title;
    }
}
