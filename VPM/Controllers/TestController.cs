using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VPM.Models;
using MongoDB.Driver;

namespace VPM.Controllers
{
    [Route("Test")]
    public class TestController : Controller
    {


        [Route("k")]
        public string k()
        {
            //send his a message so that admin chat  is always there
            var mess = new mMessages();
            mess.userEmail = "zishumbak@gmail.com";
            mess.otherPerson = globals.supportEmail;
            mess.userType = UserType.client;
            var chat = new chat();
            chat.from = globals.supportEmail;
            chat.to = "zishumbak@gmail.com";
            chat.message = "Hello, anything I can help you with?";
            chat.read = false;
            mess.chats.Add(chat);
            var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
            mcol.InsertOne(mess);


            //send his a message so that admin chat  is always there
            mess = new mMessages();
            mess.userEmail = "zishumbak@gmail.com";
            mess.otherPerson = globals.supportEmail;
            mess.userType = UserType.artisan;
            chat = new chat();
            chat.from = globals.supportEmail;
            chat.to = "zishumbak@gmail.com";
            chat.message = "Hello, anything I can help you with?";
            chat.read = false;
            mess.chats.Add(chat);
            mcol.InsertOne(mess);



            //send his a message so that admin chat  is always there
            mess = new mMessages();
            mess.userEmail = "zishumbak@gmail.com";
            mess.otherPerson = globals.supportEmail;
            mess.userType = UserType.propertyOwner;
            chat = new chat();
            chat.from = globals.supportEmail;
            chat.to = "zishumbak@gmail.com";
            chat.message = "Hello, anything I can help you with?";
            chat.read = false;
            mess.chats.Add(chat);
            mcol.InsertOne(mess);


            return "ok";
        }

        [Route("")]
        public string Index()
        {
            //var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
            //var r = new mCountry();
            //r.name = "Nigeria";
            //var s = new mStateOrProvince();
            //s.name = "Abuja FCT";
            //s.city_suburb_town_location.Add("Gudu");
            //s.city_suburb_town_location.Add("Durumi");
            //s.city_suburb_town_location.Add("Utako");
            //s.city_suburb_town_location.Add("Jabi");
            //s.city_suburb_town_location.Add("Wuye");
            //s.city_suburb_town_location.Add("Kado");
            //s.city_suburb_town_location.Add("Mabuchi");
            //s.city_suburb_town_location.Add("Katampe");
            //s.city_suburb_town_location.Add("Katampe Ext");
            //s.city_suburb_town_location.Add("Jahi");
            //s.city_suburb_town_location.Add("Dakibiya");
            //s.city_suburb_town_location.Add("Kaura");
            //s.city_suburb_town_location.Add("Duboyi");
            //s.city_suburb_town_location.Add("Gaduwa");
            //s.city_suburb_town_location.Add("Dutse");
            //s.city_suburb_town_location.Add("Asokoro");
            //s.city_suburb_town_location.Add("CBD");
            //s.city_suburb_town_location.Add("Garki 1");
            //s.city_suburb_town_location.Add("Garki 2");
            //s.city_suburb_town_location.Add("Guzape District");
            //s.city_suburb_town_location.Add("Maitama District");
            //s.city_suburb_town_location.Add("Wuse 1");
            //s.city_suburb_town_location.Add("Wuse 2");
            //s.city_suburb_town_location.Add("Karsana");
            //s.city_suburb_town_location.Add("Sabo Gida");
            //s.city_suburb_town_location.Add("Idu");
            //s.city_suburb_town_location.Add("Idogwari");
            //s.city_suburb_town_location.Add("Gwagwa");
            //s.city_suburb_town_location.Add("Kaba");
            //s.city_suburb_town_location.Add("Kajini");
            //s.city_suburb_town_location.Add("Ketti");
            //s.city_suburb_town_location.Add("Shertti cheche");
            //s.city_suburb_town_location.Add("Waru-Pouma");
            //s.city_suburb_town_location.Add("Gwari");
            //s.city_suburb_town_location.Add("Bude");
            //s.city_suburb_town_location.Add("Chafe");
            //s.city_suburb_town_location.Add("Jaite");
            //s.city_suburb_town_location.Add("Mamusa");
            //s.city_suburb_town_location.Add("Burun");
            //s.city_suburb_town_location.Add("Purfun");
            //s.city_suburb_town_location.Add("Kubwa");
            //s.city_suburb_town_location.Add("Gwagwalada");
            //s.city_suburb_town_location.Add("Nyanya");
            //s.city_suburb_town_location.Add("Karu");
            //s.city_suburb_town_location.Add("Jukwoyi");
            //s.city_suburb_town_location.Add("Lugbe");
            //s.city_suburb_town_location.Add("Chika");
            //s.city_suburb_town_location.Add("Kuchigworo");
            //s.city_suburb_town_location.Add("Mpape");
            //s.city_suburb_town_location.Add("Dei-Dei");
            //r.stateOrPorvince.Add(s);
            //ccol.InsertOne(r);

            var text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum";
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            //var props = pcol.Find(x => x._id != null).ToList();
            var update = Builders<mProperty>.Update.Set(x => x.description, text);
            pcol.UpdateMany(x => x._id!=null, update);
           /* for (int i = 0; i < 100; i++)
            {
                var p = new mProperty();
                p.propertyName = "property "+i;
                p.propertyType = "cottage";
                p.propertyCountry = "Nigeria";
                p.stateOrPorvince = "Abuja Fct";
                p.cityOrTown = "Abuja";
                p.suburb = "maitama";
                p.streetAddress = "3 bateman drive";
                p.userid = "6e012d8a-9388-4701-a7ea-9d366cbc7a9e";
               // pcol.InsertOne(p);
            }
            */
            return "Ok";
        }
    }
}
