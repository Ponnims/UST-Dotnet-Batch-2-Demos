import axios from 'axios';
import React, { useEffect, useState } from 'react'

// Axios is a popular JavaScript library used to make HTTP requests from the browser or Node.js.

// npm install axios

// syntax of axios.get() method:

// axios.get(url,config).then(response => {
//   // handle success
//   console.log(response.data);
// }).catch(error => {
//   // handle error
//   console.error(error);
// });
//  → makes a GET request to the specified URL and returns a promise that 
// resolves with the response data.

// Syntax of axios.post() method:
// axios.post(url, data, config)

// → makes a POST request to the specified URL with the provided data and returns
//  a promise that resolves with the response data.

// syntax of axios.put() method:
// axios.put(url, data, config)

// → makes a PUT request to the specified URL with the provided data and returns
//  a promise that resolves with the response data.

// syntax of axios.delete() method:
// axios.delete(url, config)

const TraineesList = () => {

    const [trainees, setTrainees] = useState([]);

    useEffect(
        () => {
            axios.get(" https://localhost:7168/api/trainee")
                .then((resp) => {
                    setTrainees(resp.data);
                    // console.log(resp.data);
                })
        }, []);


    return (
        <div>
            <h1>Trainees List</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Technology</th>
                        <th>Score</th>
                    </tr>
                </thead>

                <tbody>
                    {trainees.map((trainee) => {
                        return (
                            <tr key={trainee.id}>
                                <td>{trainee.id}</td>
                                <td>{trainee.name}</td>
                                <td>{trainee.technology}</td>
                                <td>{trainee.score}</td>
                            </tr>
                        );
                    })}

                </tbody>
            </table>

        </div>
    )
}

export default TraineesList
