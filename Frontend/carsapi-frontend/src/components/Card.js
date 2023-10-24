import React from 'react';

export default function Card(props) {
    return (
        <div className='col'>
            <div key={props.id} className="card bg-dark" style={{width: "100%"}}>
                <div className="card-body">
                    <h3 className="card-title">{props.name}</h3>
                    <h5 className="card-subtitle mb-2 text-muted">{props.color}</h5>
                    <p className="card-text">{props.description}</p>
                    <p className="card-text">{props.createdDate}</p>
                    <a href="#" className="btn btn-outline-warning">Update</a>
                    <a href="#" className="btn btn-outline-danger">Törlés</a>
                </div>
            </div>
        </div>
    );
}




