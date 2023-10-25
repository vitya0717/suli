import React from "react";
import PostModal from "./POST_modal";
//import CreateCar from './components/CreateCar'

export default function Navbar() {
    return (
        <div data-bs-theme="dark">
            <nav className="navbar navbar-expand-lg">
                <div className="container-fluid">
                    <a className="navbar-brand" href="#">CarAPI</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                            <li className="nav-item">
                                <a className="nav-link  postLink active" aria-current="page" data-bs-toggle="modal" data-bs-target="#postModal">Autó felvétele</a>
                            </li>
                            <PostModal />
                        </ul>
                        <form className="d-flex">
                            <input className="form-control me-2" type="search" placeholder="Search" aria-label="Search" />
                            <button className="btn btn-outline-success" type="submit">Search</button>
                        </form>
                    </div>
                </div>
            </nav>
        </div>
    );
}