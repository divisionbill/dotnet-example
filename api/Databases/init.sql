-- Create the 'user' table in the 'db' database
CREATE TABLE IF NOT EXISTS `Users` (
    `Id` INT AUTO_INCREMENT PRIMARY KEY,
    `Name` VARCHAR(255) NOT NULL,
    `Email` VARCHAR(255) NOT NULL
);
