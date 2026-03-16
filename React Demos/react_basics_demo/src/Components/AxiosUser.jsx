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

const AxiosUser = () => {

  const [users, setUsers] = useState([]);

  useEffect(
    () => {
      axios.get("https://jsonplaceholder.typicode.com/users")
        .then((resp) => {
          setUsers(resp.data);
          // console.log(resp.data);
        })
    }, []);


  return (
    <div>
      <h1>Users List</h1>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>City</th>
          </tr>
        </thead>

        <tbody>
          {users.map((user) => {
            return (
              <tr key={user.id}>
                <td>{user.id}</td>
                <td>{user.name}</td>
                <td>{user.email}</td>
                <td>{user.address.city}</td>
              </tr>
            );
          })}

        </tbody>
      </table>

    </div>
  )
}

export default AxiosUser
