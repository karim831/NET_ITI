use master;
create database material;
go

use material;


create table instructor(
	id int identity,
	fname varchar(10),
	lname varchar(10),
	bd date,
	overtime int unique,
	salary float check(salary like '[1000 - 3000]') default 3000,
	hirdate date default getdate(),
	addresse varchar(20) check (addresse in ('cairo','alex')),
	age as (year(getdate()) - year(bd)), -- persisted ?
	net_salary as (salary + overtime) persisted,
	constraint instructor_pk primary key (id)
);

create table course(
	cid int identity,
	cname varchar(20),
	duration int unique,
	constraint course_pk primary key (cid)
);


create table inst_course(
	inst_id int,
	cid int,
	constraint inst_course_pks primary key(inst_id,cid),
	constraint inst_course_inst_id_fk foreign key(inst_id) references instructor(id) on delete cascade on update cascade,
	constraint inst_course_cid_fk foreign key (cid) references course(cid) on delete cascade on update cascade
);

create table lab( 
	lid int identity,
	cid int,
	location varchar(20),
	capacity int check(capacity < 20),
	constraint lab_pks primary key(lid,cid),
	constraint lab_fk foreign key(cid) references course(cid) on update cascade on delete cascade
);