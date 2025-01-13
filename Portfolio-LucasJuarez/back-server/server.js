const express = require("express");
const nodemailer = require("nodemailer");
const bodyParser = require("body-parser");
const cors = require("cors");
require("dotenv").config();


const app = express();
const PORT = 3000;

app.use(cors());
app.use(bodyParser.json());

app.post("/", async (req, res) =>{
    const {email, cuerpoEmail} = req.body;

    try
    {
        const transporter = nodemailer.createTransport
        ({
            service:"gmail",
            auth:
            {
                user: process.env.KEY_USER,
                pass: process.env.KEY_PASS,
            }
        });

        const mailOptions = 
        {
            from:email,
            to: process.env.KEY_USER,
            subject:"Propuesta Laboral (Desde Portfolio)",
            text:cuerpoEmail,
        };
        await transporter.sendMail(mailOptions);
        res.status(200).send("Correo Enviado.");
    }
    catch (error)
    {
        console.log(error);
        res.status(500).send("Algo Sucedio..");
    }
})

app.listen(PORT, ()=>{
    console.log(`Acceder al SERVER.JS en http://localhost:${PORT}`)
})