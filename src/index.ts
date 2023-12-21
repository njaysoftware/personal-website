import express from 'express';
import mysql from 'mysql2';
  
const app = express();
  
app.get('/',(req,res) => {
    var con = mysql.createConnection({
    host: "172.29.224.1",
    user: "wsl_root",
    password: "password"
  });

  con.connect(function(err) {
    const sql = 'use db_blog;'
    if (err) throw err;
    console.log("Connected!");
    con.query(sql, function (err, result) {
      console.log('from the query body')
      console.log(typeof result)
      if (err) throw err;
      console.log("Result: " + JSON.stringify(result));
      con.query('select * from admin', function (err, result) {
        console.log('from the query body')
        console.log(typeof result)
        if (err) throw err;
        console.log("Result: " + JSON.stringify(result));
      })
    });
  })
  res.send({steve: 'hello World'});
})

class BaseDAO {
  constructor(
    id,
    publicId,
    createdOn,
    updatedOn
  ) {
    this.Id = id;
    this.PublicId = publicId;
    this.CreatedOn = createdOn;
    this.UpdatedOn = updatedOn;
  }
}

class AdminDAO extends BaseDAO {
  constructor(
    id,
    publicId,
    createdOn,
    updatedOn,
    firstName,
    lastName,
    userName,
    password,
    birthday,
    settings,
    perms,
  ) {
    super(
      id,
      publicId,
      createdOn,
      updatedOn,
    );
    this.FirstName = firstName;
    this.LastName = lastName;
    this.UserName = userName;
    this.Password = password;
    this.Birthday = birthday;
    this.Settings = settings;
    this.Perms = perms;
  }
}

const PORT = 5010;
  
app.listen(PORT,() => {
    console.log(`Running on PORT ${PORT}`);
})