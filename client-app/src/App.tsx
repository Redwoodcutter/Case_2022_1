import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';

function App() {
  const [activities, setActivities] = useState([]);
  const [prov, setProv] = useState([]);

  useEffect(() => {
    axios.get('http://www.mocky.io/v2/5d47f24c330000623fa3ebfa').then(response => {
      console.log(response);
      setActivities(response.data)
    })
  }, [])

  useEffect(() => {
    axios.get('http://localhost:5000/api/activity').then(response => {
      console.log(response);
      setProv(response.data)
    })
  }, [])

  return (
    <div className="App">
      <header className="App-header">
        <ul>
          <h5>Web urlden gelen seed: </h5>
          {activities.map((activity: any) => (
            <a key={activity.Id}>
              {activity.id}- zorluk : {activity.zorluk} - sure : {activity.sure}
            </a>
          ))}
          <hr></hr>
          <h5>internal url den gelen seed: </h5>
          {prov.map((activity: any) => (
            <li key={activity.Id}>
              {activity.id}- zorluk : {activity.zorluk} - sure : {activity.sure}
            </li>
          ))}
          <hr></hr>
          <h5>İş Planı : </h5>
          
        </ul>
      </header>
    </div>
  );
}

export default App;
