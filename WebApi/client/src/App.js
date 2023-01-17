import axios from 'axios'
import './App.css';
import { useState, useEffect } from 'react'


function App() {
  const [data, setdata] = useState([])
  const func = () => {
    axios.get(`http://localhost:5210/WeatherForecast`).then(response=>{
      setdata(response.data);
    })

  }
  useEffect(() => {
    func();
  }, [])

  var render = data.map(iter => {
    return (
      <p>
        {iter.date},{iter.temperatureC}
      </p>
    )
  })


  return (
    <div className="App">
      <button type='button' onClick={()=>{func()}}></button>
      {render}
    </div>
  );
}

export default App;
