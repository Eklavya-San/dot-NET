import React from 'react'
import axios from 'axios'
import { useEffect,useState } from 'react';

const Display = () => {
    const [data, setdata] = useState([]);
    useEffect(() => {
        axios.get(`http://localhost:5259/User`).then(res => {
            setdata(res.data);
        })
    }, [])

    return (
        <div>
            <table>
                <tbody>
                    <tr>
                        <th>Name</th><th>RollNo</th><th>Course</th>
                    </tr>
                    {
                        data.map(obj => {
                            return (
                                <tr>
                                    <td>{obj.name}</td>
                                    <td>{obj.rollNo}</td>
                                    <td>{obj.course}</td>
                                </tr>

                            )
                        })
                    }
                </tbody>
            </table>
        </div>
    )
}

export default Display