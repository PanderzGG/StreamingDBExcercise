create database streamingdb;

use streamingdb;

create table artist(
    ArtistID int primary key auto_increment,
    ArtistName varchar (255) not null,
    ArtistInformation text null,
    ArtistImage varchar(255) null
);

create table label(
    LabelID int primary key auto_increment,
    LabelName varchar(255) not null,
    LabelInformation text not null,
    LabelImage varchar(255) not null
);

create table album(
    AlbumID int primary key auto_increment,
    AlbumName varchar(255) not null,
    Erscheinungsjahr year not null,
    AlbumCover varchar(255) null,
    LabelID int not null,
    ArtistID int not null,
    foreign key (LabelID) references label(LabelID),
    foreign key (ArtistID) references artist(ArtistID)
);

create table genre(
    GenreID int primary key auto_increment,
    GenreName varchar(255) not null
);

create table song(
    SongID int primary key auto_increment,
    SongTitel varchar(255) not null,
    GenreID int not null,
    AlbumID int not null,
    foreign key (GenreID) references genre(GenreID),
    foreign key (AlbumID) references album(AlbumID)
);

create table featuring(
    FeaturingID int primary key auto_increment,
    SongID int not null,
    ArtistID int not null,
    foreign key (SongID) references song(SongID),
    foreign key (ArtistID) references artist(ArtistID)
);

create table songData(
    SongDataID int primary key auto_increment,
    SongDauer time not null,
    SongBPM int not null,
    SongFormat varchar(100) not null,
    SongID int not null,
    foreign key (SongID) references song(SongID)
);

use streamingdb;

-- Künstler
INSERT INTO artist (ArtistName, ArtistInformation, ArtistImage)
VALUES
('The Rolling Stones', 'Eine britische Rockband, die 1962 gegründet wurde.', 'rolling_stones.jpg'),
('Beyoncé', 'Eine US-amerikanische Sängerin, die in den 2000er Jahren bekannt wurde.', 'beyonce.jpg'),
('Eminem', 'Ein US-amerikanischer Rapper, der 1996 mit „Infinite“ debütierte.', 'eminem.jpg'),
('Daft Punk', 'Ein französisches Musikduo, bekannt für elektronische Musik.', 'daft_punk.jpg'),
('Adele', 'Eine britische Sängerin, die für ihre kraftvolle Stimme bekannt ist.', 'adele.jpg');

-- Label
INSERT INTO label (LabelName, LabelInformation, LabelImage)
VALUES
('Universal Music', 'Ein internationales Musiklabel.', 'universal_music.jpg'),
('Sony Music', 'Ein weltweites Musikunternehmen.', 'sony_music.jpg'),
('Warner Music', 'Eines der größten Musikunternehmen weltweit.', 'warner_music.jpg'),
('Columbia Records', 'Ein traditionsreiches Label in der Musikindustrie.', 'columbia_records.jpg'),
('Island Records', 'Ein internationales Label, das Künstler aus verschiedenen Genres unterstützt.', 'island_records.jpg');

-- Alben
INSERT INTO album (AlbumName, Erscheinungsjahr, AlbumCover, LabelID, ArtistID)
VALUES
('Sticky Fingers', 1971, 'sticky_fingers.jpg', 1, 1),
('Let It Bleed', 1969, 'let_it_bleed.jpg', 1, 1),
('Lemonade', 2016, 'lemonade.jpg', 2, 2),
('Dangerously In Love', 2003, 'dangerously_in_love.jpg', 2, 2),
('The Marshall Mathers LP', 2000, 'marshall_mathers.jpg', 3, 3),
('Recovery', 2010, 'recovery.jpg', 3, 3),
('Discovery', 2001, 'discovery.jpg', 4, 4),
('Random Access Memories', 2013, 'random_access_memories.jpg', 4, 4),
('25', 2015, '25.jpg', 5, 5),
('21', 2011, '21.jpg', 5, 5);

-- Genres
INSERT INTO genre (GenreName)
VALUES
('Rock'),
('Pop'),
('Rap'),
('Electronic'),
('Soul');


-- Songs
-- Album: Sticky Fingers (The Rolling Stones)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Brown Sugar', 1, 1),   -- Rock Song
('Gimme Shelter', 1, 1), -- Rock Song
('Wild Horses', 1, 1),   -- Rock Song
('Can\'t You Hear Me Knocking', 1, 1); -- Rock Song

-- Album: Let It Bleed (The Rolling Stones)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Gimme Shelter', 1, 2),   -- Rock Song
('You Can\'t Always Get What You Want', 1, 2), -- Rock Song
('Love In Vain', 1, 2),     -- Rock Song
('Midnight Rambler', 1, 2); -- Rock Song

-- Album: Lemonade (Beyoncé)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Formation', 2, 3),  -- Pop Song
('Sorry', 2, 3),      -- Pop Song
('Hold Up', 2, 3),    -- Pop Song
("Don\'t Hurt Yourself", 2, 3); -- Pop Song

-- Album: Dangerously In Love (Beyoncé)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Crazy In Love', 2, 4),  -- Pop Song
('Baby Boy', 2, 4),       -- Pop Song
('Naughty Girl', 2, 4),   -- Pop Song
('Me, Myself and I', 2, 4); -- Pop Song

-- Album: The Marshall Mathers LP (Eminem)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Lose Yourself', 3, 5),    -- Rap Song
('Cleaning Out My Closet', 3, 5), -- Rap Song
('Stan', 3, 5),             -- Rap Song
('The Way I Am', 3, 5);     -- Rap Song

-- Album: Recovery (Eminem)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Not Afraid', 3, 6),     -- Rap Song
('Love The Way You Lie', 3, 6), -- Rap Song
('No Love', 3, 6),        -- Rap Song
('Space Bound', 3, 6);    -- Rap Song

-- Album: Discovery (Daft Punk)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('One More Time', 4, 7),   -- Electronic Song
('Aerodynamic', 4, 7),     -- Electronic Song
('Digital Love', 4, 7),    -- Electronic Song
('Harder, Better, Faster, Stronger', 4, 7); -- Electronic Song

-- Album: Random Access Memories (Daft Punk)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Get Lucky', 4, 8),    -- Electronic Song
('Instant Crush', 4, 8), -- Electronic Song
('Lose Yourself to Dance', 4, 8), -- Electronic Song
('Touch', 4, 8);        -- Electronic Song

-- Album: 25 (Adele)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Hello', 5, 9),        -- Soul Song
('When We Were Young', 5, 9), -- Soul Song
('Send My Love (To Your New Lover)', 5, 9), -- Soul Song
('Water Under the Bridge', 5, 9); -- Soul Song

-- Album: 21 (Adele)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES
('Someone Like You', 5, 10), -- Soul Song
('Rolling in the Deep', 5, 10), -- Soul Song
('Set Fire to the Rain', 5, 10), -- Soul Song
('Rumour Has It', 5, 10); -- Soul Song

-- Featuring
-- "Main Artist" an erster Stelle, weitere Künstler als Feature
-- Für jedes Album der Hauptkünstler mit sich selbst und ggf. anderen Künstlern in der Featuring-Tabelle

-- Sticky Fingers
INSERT INTO featuring (SongID, ArtistID) VALUES (1, 1);  -- Brown Sugar (Main: The Rolling Stones)
INSERT INTO featuring (SongID, ArtistID) VALUES (2, 1);  -- Gimme Shelter (Main: The Rolling Stones)
INSERT INTO featuring (SongID, ArtistID) VALUES (3, 1);  -- Wild Horses (Main: The Rolling Stones)
INSERT INTO featuring (SongID, ArtistID) VALUES (4, 1);  -- Can't You Hear Me Knocking (Main: The Rolling Stones)

-- Let It Bleed
INSERT INTO featuring (SongID, ArtistID) VALUES (5, 1);  -- Gimme Shelter (Main: The Rolling Stones)
INSERT INTO featuring (SongID, ArtistID) VALUES (6, 1);  -- You Can't Always Get What You Want (Main: The Rolling Stones)
INSERT INTO featuring (SongID, ArtistID) VALUES (7, 1);  -- Love In Vain (Main: The Rolling Stones)
INSERT INTO featuring (SongID, ArtistID) VALUES (8, 1);  -- Midnight Rambler (Main: The Rolling Stones)

-- Lemonade
INSERT INTO featuring (SongID, ArtistID) VALUES (9, 2);  -- Formation (Main: Beyoncé)
INSERT INTO featuring (SongID, ArtistID) VALUES (10, 2); -- Sorry (Main: Beyoncé)
INSERT INTO featuring (SongID, ArtistID) VALUES (11, 2); -- Hold Up (Main: Beyoncé)
INSERT INTO featuring (SongID, ArtistID) VALUES (12, 2); -- Don't Hurt Yourself (Main: Beyoncé)

-- Dangerously In Love
INSERT INTO featuring (SongID, ArtistID) VALUES (13, 2); -- Crazy In Love (Main: Beyoncé)
INSERT INTO featuring (SongID, ArtistID) VALUES (14, 2); -- Baby Boy (Main: Beyoncé)
INSERT INTO featuring (SongID, ArtistID) VALUES (15, 2); -- Naughty Girl (Main: Beyoncé)
INSERT INTO featuring (SongID, ArtistID) VALUES (16, 2); -- Me, Myself and I (Main: Beyoncé)

-- The Marshall Mathers LP
INSERT INTO featuring (SongID, ArtistID) VALUES (17, 3); -- Lose Yourself (Main: Eminem)
INSERT INTO featuring (SongID, ArtistID) VALUES (18, 3); -- Cleaning Out My Closet (Main: Eminem)
INSERT INTO featuring (SongID, ArtistID) VALUES (19, 3); -- Stan (Main: Eminem)
INSERT INTO featuring (SongID, ArtistID) VALUES (20, 3); -- The Way I Am (Main: Eminem)

-- Recovery
INSERT INTO featuring (SongID, ArtistID) VALUES (21, 3); -- Not Afraid (Main: Eminem)
INSERT INTO featuring (SongID, ArtistID) VALUES (22, 3); -- Love The Way You Lie (Main: Eminem)
INSERT INTO featuring (SongID, ArtistID) VALUES (23, 3); -- No Love (Main: Eminem)
INSERT INTO featuring (SongID, ArtistID) VALUES (24, 3); -- Space Bound (Main: Eminem)

-- Discovery
INSERT INTO featuring (SongID, ArtistID) VALUES (25, 4); -- One More Time (Main: Daft Punk)
INSERT INTO featuring (SongID, ArtistID) VALUES (26, 4); -- Aerodynamic (Main: Daft Punk)
INSERT INTO featuring (SongID, ArtistID) VALUES (27, 4); -- Digital Love (Main: Daft Punk)
INSERT INTO featuring (SongID, ArtistID) VALUES (28, 4); -- Harder, Better, Faster, Stronger (Main: Daft Punk)

-- Random Access Memories
INSERT INTO featuring (SongID, ArtistID) VALUES (29, 4); -- Get Lucky (Main: Daft Punk)
INSERT INTO featuring (SongID, ArtistID) VALUES (30, 4); -- Instant Crush (Main: Daft Punk)
INSERT INTO featuring (SongID, ArtistID) VALUES (31, 4); -- Lose Yourself to Dance (Main: Daft Punk)
INSERT INTO featuring (SongID, ArtistID) VALUES (32, 4); -- Touch (Main: Daft Punk)

-- 25
INSERT INTO featuring (SongID, ArtistID) VALUES (33, 5); -- Hello (Main: Adele)
INSERT INTO featuring (SongID, ArtistID) VALUES (34, 5); -- When We Were Young (Main: Adele)
INSERT INTO featuring (SongID, ArtistID) VALUES (35, 5); -- Send My Love (To Your New Lover) (Main: Adele)
INSERT INTO featuring (SongID, ArtistID) VALUES (36, 5); -- Water Under the Bridge (Main: Adele)

-- 21
INSERT INTO featuring (SongID, ArtistID) VALUES (37, 5); -- Someone Like You (Main: Adele)
INSERT INTO featuring (SongID, ArtistID) VALUES (38, 5); -- Rolling in the Deep (Main: Adele)
INSERT INTO featuring (SongID, ArtistID) VALUES (39, 5); -- Set Fire to the Rain (Main: Adele)
INSERT INTO featuring (SongID, ArtistID) VALUES (40, 5); -- Rumour Has It (Main: Adele)

-- SongData (überarbeitete Version)
INSERT INTO songData (SongDauer, SongBPM, SongFormat, SongID)
VALUES
('3:50', 115, 'MP3', 1),   -- Brown Sugar (Sticky Fingers)
('4:30', 120, 'MP3', 2),   -- Gimme Shelter (Sticky Fingers)
('5:10', 125, 'MP3', 3),   -- Wild Horses (Sticky Fingers)
('5:00', 130, 'MP3', 4),   -- Can't You Hear Me Knocking (Sticky Fingers)

('6:00', 110, 'MP3', 5),   -- Gimme Shelter (Let It Bleed)
('7:00', 115, 'MP3', 6),   -- You Can't Always Get What You Want (Let It Bleed)
('4:50', 120, 'MP3', 7),   -- Love In Vain (Let It Bleed)
('6:30', 125, 'MP3', 8),   -- Midnight Rambler (Let It Bleed)

('4:50', 115, 'MP3', 9),   -- Formation (Lemonade)
('5:00', 120, 'MP3', 10),  -- Sorry (Lemonade)
('4:40', 118, 'MP3', 11),  -- Hold Up (Lemonade)
('5:10', 125, 'MP3', 12),  -- Don't Hurt Yourself (Lemonade)

('5:30', 115, 'MP3', 13),  -- Crazy In Love (Dangerously In Love)
('5:00', 120, 'MP3', 14),  -- Baby Boy (Dangerously In Love)
('4:50', 125, 'MP3', 15),  -- Naughty Girl (Dangerously In Love)
('4:40', 118, 'MP3', 16),  -- Me, Myself and I (Dangerously In Love)

('5:30', 128, 'MP3', 17),  -- Lose Yourself (The Marshall Mathers LP)
('5:00', 120, 'MP3', 18),  -- Cleaning Out My Closet (The Marshall Mathers LP)
('6:00', 115, 'MP3', 19),  -- Stan (The Marshall Mathers LP)
('5:10', 130, 'MP3', 20),  -- The Way I Am (The Marshall Mathers LP)

('4:40', 125, 'MP3', 21),  -- Not Afraid (Recovery)
('4:30', 120, 'MP3', 22),  -- Love The Way You Lie (Recovery)
('5:00', 130, 'MP3', 23),  -- No Love (Recovery)
('5:20', 115, 'MP3', 24),  -- Space Bound (Recovery)

('5:20', 118, 'MP3', 25),  -- One More Time (Discovery)
('4:50', 120, 'MP3', 26),  -- Aerodynamic (Discovery)
('5:10', 125, 'MP3', 27),  -- Digital Love (Discovery)
('5:40', 130, 'MP3', 28),  -- Harder, Better, Faster, Stronger (Discovery)

('6:00', 128, 'MP3', 29),  -- Get Lucky (Random Access Memories)
('5:30', 115, 'MP3', 30),  -- Instant Crush (Random Access Memories)
('5:40', 120, 'MP3', 31),  -- Lose Yourself to Dance (Random Access Memories)
('7:00', 130, 'MP3', 32),  -- Touch (Random Access Memories)

('5:20', 115, 'MP3', 33),  -- Hello (25)
('4:50', 120, 'MP3', 34),  -- When We Were Young (25)
('3:40', 118, 'MP3', 35),  -- Send My Love (To Your New Lover) (25)
('4:30', 125, 'MP3', 36),  -- Water Under the Bridge (25)

('4:50', 130, 'MP3', 37),  -- Someone Like You (21)
('5:00', 125, 'MP3', 38),  -- Rolling in the Deep (21)
('5:10', 120, 'MP3', 39),  -- Set Fire to the Rain (21)
('4:40', 115, 'MP3', 40);  -- Rumour Has It (21)

