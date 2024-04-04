CREATE TABLE shapes (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    shapeName TEXT,
    shapeLength INTEGER,
    shapeWidth INTEGER
);

INSERT INTO shapes (name) VALUES ('Test Square', 10, 10);
INSERT INTO shapes (name) VALUES ('Test Rectangle', 5, 10);