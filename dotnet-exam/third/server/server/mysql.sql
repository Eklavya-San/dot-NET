DROP DATABASE IF EXISTS studentdata;
CREATE DATABASE studentdata;
use studentdata;
create table user(
    rollno integer,
    name varchar(20),
    course varchar(20)
);
insert into user values (1,"Eklavya","dac");