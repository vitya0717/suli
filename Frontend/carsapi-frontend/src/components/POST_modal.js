import React from "react";
import * as methods from './methods'

export default function PostModal() {
    return (
        <div className="modal fade"
            id="postModal"
            data-bs-backdrop="static"
            data-bs-keyboard="false"
            tabIndex="-1"
            aria-labelledby="postModalLabel"
            aria-hidden="true">
            <div className="modal-dialog">
                <div className="modal-content">
                    <div className="modal-header">
                        <h5 className="modal-title" id="postModalLabel">Új autó hozzáadás</h5>
                        <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="close"></button>
                    </div>
                    <div className="modal-body">
                        <form className="needs-validation" noValidate>
                            <div className="input-group mb-3">
                                <span className="input-group-text">Név</span>
                                <input onKeyUp={methods.validation} type="text" className="form-control" aria-label="Sizing example input" id="inputName" required />
                                <div className="invalid-feedback">
                                    Adj meg egy autónevet!
                                </div>
                            </div>
                            <div className="input-group mb-3">
                                <span className="input-group-text">Szín</span>
                                <input onKeyUp={methods.validation} type="text" className="form-control" aria-label="Sizing example input" id="inputColor" />
                                <div className="invalid-feedback">
                                    Adj meg egy színt az autónak!
                                </div>
                            </div>
                            <div className="input-group mb-3">
                                <span className="input-group-text">Leírás</span>
                                <input onKeyUp={methods.validation} type="text" className="form-control" aria-label="Sizing example input" id="inputDescription" />
                                <div className="invalid-feedback">
                                    Adj meg egy leírást az autóról!
                                </div>
                            </div>
                        </form>
                    </div>
                    <div className="modal-footer">
                        <button type="button" className="btn btn-secondary" data-bs-dismiss="modal">Mégsem</button>
                        <button type="button" onClick={methods.postMethod} className="btn btn-primary">Hozzáadás</button>
                    </div>
                </div>
            </div>
        </div>
    )
}
