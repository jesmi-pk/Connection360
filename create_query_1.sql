Use Connection360

CREATE TABLE brand(
brand_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
brand_name VARCHAR(250),
brand_logo VARCHAR(250),
brand_description TEXT);


CREATE TABLE sku(
sku_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
sku_name VARCHAR(250),
sku_image VARCHAR(250));


CREATE TABLE map_brand_sku(
map_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
brand_id INT,
sku_id INT,
constraint fk_map_brand_id foreign key (brand_id) references brand (brand_id),
constraint fk_map_sku_id foreign key (sku_id) references sku (sku_id)
);

CREATE TABLE survey(
survey_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
survey_title VARCHAR(250),
survey_display_from_date date,
survey_display_to_date date,
survey_image varchar(250),
survey_status bit 
);

CREATE TABLE survey_option(
survey_option_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
survey_option_text VARCHAR(250));

CREATE TABLE survey_option_type(
survey_option_type_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
survey_option_type_name VARCHAR(250));

CREATE TABLE survey_question(
survey_question_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
survey_question_text VARCHAR(250),
survey_option_type_id INT,
constraint fk_survey_question_option_type foreign key (survey_option_type_id) references survey_option_type (survey_option_type_id)
);



CREATE TABLE survey_question_detail(
survey_question_detail_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
survey_question_id INT,
survey_option_id INT,
constraint fk_map_survey_question_id foreign key (survey_question_id) references survey_question (survey_question_id),
constraint fk_map_survey_option_id foreign key (survey_option_id) references survey_option (survey_option_id)
);

CREATE TABLE survey_detail(
survey_detail_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
survey_id INT,
survey_question_id INT,
constraint fk_map_survey_id foreign key (survey_id) references survey (survey_id),
constraint fk_map_question_id foreign key (survey_question_id) references survey_question (survey_question_id)
);


