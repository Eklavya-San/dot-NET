import React from 'react'
import axios from 'axios';
import { useState, } from 'react'
const Form = () => {
    const [data, setdata] = useState([])
    const savedata =(event)=>{
        event.preventDefault();
        axios.post('http://localhost:5259/User',data);
    }
    const handleChange=(event)=>{
        const {name,value}=event.target;
        setdata({...data,[name]:value})
    }
    
  return (
    <div>
        <form action='POST' onSubmit={savedata}>
            <input type='number' name='rollno' onChange={handleChange}></input>
            <input type='text' name='name'onChange={handleChange} ></input>
            <input type='text' name='course'onChange={handleChange} ></input>
            <input type="submit"></input>
        </form>
    </div>
  )
}

export default Form