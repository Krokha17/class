using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;

public class Post
{
    public int id { get; set; }
    public string description { get; set; }
    public Post() { }
    public Post (int id, string description)
    {
        this.id = id;
        this.description = description;
    }
}
public class Worker
{
    public int id { get; set; }
    public string Posts { get; set; }
    public string Name { get; set; } 
    public Worker() { }
    public Worker(int id, string Posts, string Name)
    {
        this.id = id;
        this.Posts = Posts;
        this.Name = Name;
    }
}
public class Works
{
    public int id { get; set; }
    public string Action { get; set; }
    public string Worker { get; set; }
    public int id_action { get; set; }
    public int id_bakery { get; set; }
    public Works() { }
    public Works(int id, string Action, string Worker, int id_action, int id_bakery)
    {
        this.id = id;
        this.Action = Action;
        this.Worker = Worker;
        this.id_action = id_action;
        this.id_bakery = id_bakery;
    }
}
public class Bakerys
{
    public int id_bakery { get; set; }
    public string Number { get; set; }
    public string Name { get; set; }
    public string Street { get; set; }
    public int Number_house { get; set; }
    public Bakerys() { }
    public Bakerys(int id_bakery, string Number, string Name, string Street, int Number_house)
    {
        this.id_bakery = id_bakery;
        this.Number = Number;
        this.Name = Name;
        this.Street = Street;
        this.Number_house = Number_house;
    }
}
public class Actions
{
    public int id_action { get; set; }
    public string Action { get; set; }
    public Actions() { }
    public Actions(int id_action, string Action)
    {
        this.id_action = id_action;
        this.Action = Action;
    }
}
public class Measures
{
    public int id_measure { get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
    public Measures() { }
    public Measures(int id_measure, string Name, DateTime Time)
    {
        this.id_measure = id_measure;
        this.Name = Name;
        this.Time = Time; 
    }
}
public class Opens
{
    public int id_measure { get; set; }
    public int id_measure { get; set; }
    public int id_bakery { get; set; }
    public Opens() { }
    public Opens(int id_measure, int id_measure, int id_bakery)
    {
        this.id_measure = id_measure;
        this.id_measure = id_measure;
        this.id_bakery = id_bakery;
    }
}