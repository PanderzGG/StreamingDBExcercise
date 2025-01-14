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
('The Rolling Stones', 'Eine britische Rockband, die 1962 gegründet wurde.', 'rolling_stones.png'),
('Beyoncé', 'Eine US-amerikanische Sängerin, die in den 2000er Jahren bekannt wurde.', 'beyonce.png'),
('Eminem', 'Ein US-amerikanischer Rapper, der 1996 mit „Infinite“ debütierte.', 'eminem.png'),
('Daft Punk', 'Ein französisches Musikduo, bekannt für elektronische Musik.', 'daft_punk.png'),
('Adele', 'Eine britische Sängerin, die für ihre kraftvolle Stimme bekannt ist.', 'adele.png'),
('Kendrick Lamar', 'US-amerikanischer Rapper, Songwriter und Produzent', 'kendrick_lamar.png');

-- Label
INSERT INTO label (LabelName, LabelInformation, LabelImage)
VALUES
('Universal Music', 'Ein internationales Musiklabel.', 'universal_music.png'),
('Sony Music', 'Ein weltweites Musikunternehmen.', 'sony_music.png'),
('Warner Music', 'Eines der größten Musikunternehmen weltweit.', 'warner_music.png'),
('Columbia Records', 'Ein traditionsreiches Label in der Musikindustrie.', 'columbia_records.png'),
('Island Records', 'Ein internationales Label, das Künstler aus verschiedenen Genres unterstützt.', 'island_records.png'),
('Top Dawg Entertainment', 'Independent-Label mit Fokus auf Hip-Hop-Künstler', 'tde_logo.png');

-- Alben
INSERT INTO album (AlbumName, Erscheinungsjahr, AlbumCover, LabelID, ArtistID)
VALUES
('Sticky Fingers', 1971, 'sticky_fingers.png', 1, 1),
('Let It Bleed', 1969, 'let_it_bleed.png', 1, 1),
('Lemonade', 2016, 'lemonade.png', 2, 2),
('Dangerously In Love', 2003, 'dangerously_in_love.png', 2, 2),
('The Marshall Mathers LP', 2000, 'marshall_mathers.png', 3, 3),
('Recovery', 2010, 'recovery.png', 3, 3),
('Discovery', 2001, 'discovery.png', 4, 4),
('Random Access Memories', 2013, 'random_access_memories.png', 4, 4),
('25', 2015, '25.png', 5, 5),
('21', 2011, '21.png', 5, 5),
('GNX', 2024, 'gnx.png', 6, 6);


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

-- Album: gnx (Kendrick Lamar)
INSERT INTO song (SongTitel, GenreID, AlbumID)
VALUES 
('Wacced Out Murals', 3, 11),
('Squabble Up', 3, 11),
('Gloria', 3, 11),
('Luther', 3, 11),
('GNX Intro', 3, 11),
('Cali Sunrise', 3, 11),
('Ride or Die', 3, 11),
('Legacy Hustle', 3, 11),
('Daydreamer', 3, 11),
('Fire and Fury', 3, 11),
('Silent Thunder', 3, 11),
('Victory Lap', 3, 11);

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

INSERT INTO featuring (SongID, ArtistID)
VALUES
(41, 6), -- Kendrick Lamar für 'Wacced Out Murals'
(42, 6), -- Kendrick Lamar für 'Squabble Up'
(43, 6), -- Kendrick Lamar für 'Gloria'
(44, 6), -- Kendrick Lamar für 'Luther'
(45, 6), -- Kendrick Lamar für 'GNX Intro'
(46, 6), -- Kendrick Lamar für 'Cali Sunrise'
(47, 6), -- Kendrick Lamar für 'Ride or Die'
(48, 6), -- Kendrick Lamar für 'Legacy Hustle'
(49, 6), -- Kendrick Lamar für 'Daydreamer'
(50, 6), -- Kendrick Lamar für 'Fire and Fury'
(51, 6), -- Kendrick Lamar für 'Silent Thunder'
(52, 6); -- Kendrick Lamar für 'Victory Lap'

-- SongData (überarbeitet)
INSERT INTO songData (SongDauer, SongBPM, SongFormat, SongID)
VALUES
('00:03:50', 115, 'MP3', 1),   -- Brown Sugar (Sticky Fingers)
('00:04:30', 120, 'MP3', 2),   -- Gimme Shelter (Sticky Fingers)
('00:05:10', 125, 'MP3', 3),   -- Wild Horses (Sticky Fingers)
('00:05:00', 130, 'MP3', 4),   -- Can't You Hear Me Knocking (Sticky Fingers)

('00:06:00', 110, 'MP3', 5),   -- Gimme Shelter (Let It Bleed)
('00:07:00', 115, 'MP3', 6),   -- You Can't Always Get What You Want (Let It Bleed)
('00:04:50', 120, 'MP3', 7),   -- Love In Vain (Let It Bleed)
('00:06:30', 125, 'MP3', 8),   -- Midnight Rambler (Let It Bleed)

('00:04:50', 115, 'MP3', 9),   -- Formation (Lemonade)
('00:05:00', 120, 'MP3', 10),  -- Sorry (Lemonade)
('00:04:40', 118, 'MP3', 11),  -- Hold Up (Lemonade)
('00:05:10', 125, 'MP3', 12),  -- Don't Hurt Yourself (Lemonade)

('00:05:30', 115, 'MP3', 13),  -- Crazy In Love (Dangerously In Love)
('00:05:00', 120, 'MP3', 14),  -- Baby Boy (Dangerously In Love)
('00:04:50', 125, 'MP3', 15),  -- Naughty Girl (Dangerously In Love)
('00:04:40', 118, 'MP3', 16),  -- Me, Myself and I (Dangerously In Love)

('00:05:30', 128, 'MP3', 17),  -- Lose Yourself (The Marshall Mathers LP)
('00:05:00', 120, 'MP3', 18),  -- Cleaning Out My Closet (The Marshall Mathers LP)
('00:06:00', 115, 'MP3', 19),  -- Stan (The Marshall Mathers LP)
('00:05:10', 130, 'MP3', 20),  -- The Way I Am (The Marshall Mathers LP)

('00:04:40', 125, 'MP3', 21),  -- Not Afraid (Recovery)
('00:04:30', 120, 'MP3', 22),  -- Love The Way You Lie (Recovery)
('00:05:00', 130, 'MP3', 23),  -- No Love (Recovery)
('00:05:20', 115, 'MP3', 24),  -- Space Bound (Recovery)

('00:05:20', 118, 'MP3', 25),  -- One More Time (Discovery)
('00:04:50', 120, 'MP3', 26),  -- Aerodynamic (Discovery)
('00:05:10', 125, 'MP3', 27),  -- Digital Love (Discovery)
('00:05:40', 130, 'MP3', 28),  -- Harder, Better, Faster, Stronger (Discovery)

('00:06:00', 128, 'MP3', 29),  -- Get Lucky (Random Access Memories)
('00:05:30', 115, 'MP3', 30),  -- Instant Crush (Random Access Memories)
('00:05:40', 120, 'MP3', 31),  -- Lose Yourself to Dance (Random Access Memories)
('00:07:00', 130, 'MP3', 32),  -- Touch (Random Access Memories)

('00:05:20', 115, 'MP3', 33),  -- Hello (25)
('00:04:50', 120, 'MP3', 34),  -- When We Were Young (25)
('00:03:40', 118, 'MP3', 35),  -- Send My Love (To Your New Lover) (25)
('00:04:30', 125, 'MP3', 36),  -- Water Under the Bridge (25)

('00:04:50', 130, 'MP3', 37),  -- Someone Like You (21)
('00:05:00', 125, 'MP3', 38),  -- Rolling in the Deep (21)
('00:05:10', 120, 'MP3', 39),  -- Set Fire to the Rain (21)
('00:04:40', 115, 'MP3', 40),

('00:03:45', 120, 'MP3', 41),
('00:04:10', 130, 'MP3', 42),
('00:03:50', 125, 'MP3', 43),
('00:03:30', 115, 'MP3', 44),
('00:01:20', 0, 'MP3', 45),
('00:04:00', 118, 'MP3', 46),
('00:03:55', 122, 'MP3', 47),
('00:04:05', 125, 'MP3', 48),
('00:03:40', 110, 'MP3', 49),
('00:04:15', 128, 'MP3', 50),
('00:03:35', 115, 'MP3', 51),
('00:05:00', 132, 'MP3', 52);


