// See https://aka.ms/new-console-template for more information
using BuilderPattern;

var AppointmentBuilder=new AppointmentBuilder()
    .Name("Vishal Singh")
    .Age(24)
    .BloodGroup("AB+")
    .Symptoms("Cough")
    .Symptoms("fever")
    .OtherConditions("none")
    .build();

