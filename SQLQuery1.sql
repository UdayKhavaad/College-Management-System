create table teacher
(
tID int Not Null Identity(1,1) primary key,
fname varchar(250) not null,
gender varchar(10) not null,
dob varchar(50) not null,
mobile bigint not null,
email varchar (250),
semester varchar(250) not null,
prog varchar(100) not null,
yer varchar(250) not null,
adr varchar(300) not null
)