CREATE TABLE Wishes (
 ID integer not null PRIMARY key AUTOINCREMENT,
 Name text not null,
 Age integer not null,
 Wish text not null,
 Amount integer not null,
 UNIQUE(Name)
);
