import React from 'react';
import axios from 'axios';
import ReactDOM from 'react-dom/client';
import Navbar from './components/Navbar';
import Card from './components/Card';
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.min.js'
import './style.css'
import Specialist from './components/Specialist';


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <App />
);

axios.get("https://localhost:7141/api/Car").then(res => localStorage.setItem("cars", JSON.stringify(res.data.result)));
const cars = JSON.parse(localStorage.getItem("cars"));

function App() {
  return (
    <div className='container'>
      <Navbar />
      <div className='row'>
      {
        cars.map((item) => {
          return <Card key={item.id} name={item.name} description={item.description} color={item.color} createdDate={item.createdDate}/>
        })
      }
      <Specialist />
      </div>
    </div>
  );
}

