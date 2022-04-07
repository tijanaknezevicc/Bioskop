use master
create database Bioskop3
use Bioskop3

create table film
(
	id int identity(1,1) primary key,
	naziv nvarchar(50),
	zanr varchar(15),
	idOpisa int	
)

create table sala
(
	id int identity(1,1) primary key,
	terminPocetak time,
	terminKraj time,
	idFilma int,
	brSale nvarchar(30)
)

create table opis
(
	id int identity(1,1) primary key,
	punNaziv varchar(50),
	trajanje time,
	glumci varchar(max),
	sinopsis varchar(max),
	trailer nvarchar(max),
	ocena varchar(3)
)

insert into film
values
('Spajdermen', 'Akcija', 1),
('Betmen', 'Akcija', 2),
('Enkanto', 'Animirani film', 3),
('Kobaja zureza', 'Animirani film', 4)

insert into opis
values
('Spajdermen: Put bez povratka', '02:28:00', 'Tom Holland, Zendaya, Jacob Batalon, Benedict Cumberbatch', 'Piter Parker traži od doktora Stivena Strejndža da svoj identitet Spajdermena ponovo učini tajnom magijom nakon njegovog javnog otkrića, ali ovo razbija multiverzum i dozvoljava da pet superzlikovaca iz alternativnih stvarnosti, koji su se borili protiv sopstvenih verzija Parkera, uđu u njegov univerzum.', 'https://www.youtube.com/embed/JfVOs4VSpmA', '8.5'),
('Betmen', '02:56:00', 'Robert Pattinson, Matt Reeves, Paul Dano, Zoe Kravitz', 'Nakon godina lutanja ulicama Gotama, i sa tek nekoliko pouzdanih saveznika — usamljeni osvetnik postaje jedino utelovljenje pravde među svojim sugrađanima. Kada Gotamovu elitu napadne sadistički ubica, niz zagonetnih tragova vodi najvećeg istražitelja podzemlja u najmračniju avanturu do sada.', 'https://www.youtube.com/embed/mqqft2x_Aa4', '8.3'),
('Enkanto', '01:39:00', 'Stephanie Beatriz, John Leguizamo, Wilmer Valderrama, Maluma', 'Maribel je simpatična, smešna, pomalo trapava petnaestogodišnjakinja koja nosi naočare i ne odvaja se od svoje harmonike. Jedina u porodici nema magijom obojenu svakodnevicu, jer je kako kažu njeni prijatelji i porodica — možda dar malo ignoriše.', 'https://www.youtube.com/embed/CaimKeDcudo', '7.3'),
('Kobaja zureza', '01:29:00', 'Seth Rogen, James Franco, Jonah Hill, Michael Cera', 'Glavni lik filma je Frenk, viršla koja predvodi grupu prehrambenih proizvoda na epskom putovanju otkrivanja prave istine o tome što se događa kada hrana napusti udobnost polica prodavnica. Njihova potera za istinom odvešće ih u najmračnije delove trgovine ispunjene sumnjivim tipovima.', 'https://www.youtube.com/embed/WVAcTZKTgmc', '6.1')

insert into sala
values
('15:00:00', '17:00:00', 4, 'Sala pundravci'),
('15:00:00', '18:00:00', 1, 'Sala psihomodopop'),
('17:00:00', '19:00:00', 3, 'Sala pundravci'),
('18:00:00', '21:00:00', 2, 'Sala psihomodopop'),
('19:00:00', '21:00:00', 4, 'Sala pundravci'),
('21:00:00', '23:00:00', 3, 'Sala pundravci'),
('21:00:00', '00:00:00', 1, 'Sala psihomodopop'),
('23:00:00', '01:00:00', 4, 'Sala pundravci')

go
create view Pogled
as
select film.naziv as Film, convert(varchar(5), sala.terminPocetak) as Vreme, sala.brSale as Sala
from sala full join film on sala.idFilma=film.id
go

go
create function punNaziv(@ime varchar(50))
returns varchar(50) as
begin
	return (select opis.punNaziv from opis where opis.id in (select film.idOpisa from film where film.naziv = @ime))
end
go

go
create function filmOcena(@ime varchar(50))
returns varchar(3) as
begin
	return (select opis.ocena from opis where opis.id in (select film.idOpisa from film where film.naziv = @ime))
end
go

go
create function trajanje(@ime varchar(50))
returns varchar(5) as
begin
	return (select convert(varchar(5), opis.trajanje) from opis where opis.id in (select film.idOpisa from film where film.naziv = @ime))
end
go

go
create function glumci(@ime varchar(50))
returns varchar(max) as
begin
	return (select opis.glumci from opis where opis.id in (select film.idOpisa from film where film.naziv = @ime))
end
go

go
create function filmOpis(@ime varchar(50))
returns varchar(max) as
begin
	return (select opis.sinopsis from opis where opis.id in (select film.idOpisa from film where film.naziv = @ime))
end
go

go
create function link(@ime varchar(50))
returns varchar(max) as
begin
	return (select opis.trailer from opis where opis.id in (select film.idOpisa from film where film.naziv = @ime))
end
go