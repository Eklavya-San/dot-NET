DROP DATABASE IF EXISTS nova;
create database nova;
use nova;
create table users (
    userid integer primary key auto_increment,
    username varchar(50),
    course varchar(50),
    fees integer
);

insert into users values (1,"Eklavya","dac",150000);