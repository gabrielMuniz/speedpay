import React, { useState } from 'react';

import { makeStyles } from '@material-ui/core/styles';
import { TextField, Radio, Checkbox, FormControlLabel, Button, List, ListItem, ListItemText } from '@material-ui/core';
import { postProvider } from '../../services/api';

const useStyles = makeStyles((theme) => ({
    root: {
        '& > *': {
            margin: 20,
            width: '25ch',
        },
        color: "black"
    },
}));


const ProviderFormPage = (props) => {

    const handlePhone = phone => {
        let p = phones;
        p.push(phone);
        setPhones(p);
        setActualPhoneNumber('');
        setActualPhoneNumberIsEmpty(true);
    }

    const handleActualPhoneNumber = number => {
        setActualPhoneNumber(number);
        if (!number)
            setActualPhoneNumberIsEmpty(true);
        else
            setActualPhoneNumberIsEmpty(false);
    }

    const sendProvider = () => {
        const provider = {
            generalRegistration,
            federalRegistration,
            phones: phones.map(phone => {
                return { phoneNumber: phone };
            }),
            name
        };
        postProvider(provider);
    }

    const [phisic, setPhisic] = useState(false);
    const [phones, setPhones] = useState([]);
    const [actualPhoneNumber, setActualPhoneNumber] = useState("");
    const [actualPhoneNumberIsEmpty, setActualPhoneNumberIsEmpty] = useState(true);
    const [federalRegistration, setFederalRegistration] = useState("");
    const [generalRegistration, setGeneralRegistration] = useState("");
    const [name, setName] = useState("");
    const classes = useStyles();

    return (
        <form className={classes.root} noValidate autoComplete="off">

            <h2>Cadastro de fornecedor</h2>
            <TextField id="name" label="Nome" onChange={(e) => setName(e.target.value)} />
            <FormControlLabel control={<Checkbox name="phisic" />}
                label="Pessoa física" onChange={() => setPhisic(!phisic)} />
            <TextField id="federalRegistration" onChange={(e) => setFederalRegistration(e.target.value)} label="CPF/CNPJ" />
            <TextField id="generalRegistration" onChange={(e) => setGeneralRegistration(e.target.value)} disabled={!phisic} label="RG" />

            <section>
                <div>
                    <h3>Telefones</h3>
                    <TextField value={actualPhoneNumber} onChange={(e) => handleActualPhoneNumber(e.target.value)} id="phoneNumber" label="Telefone" />
                    <Button style={{ marginTop: 10 }} disabled={actualPhoneNumberIsEmpty} onClick={() => handlePhone(actualPhoneNumber)} variant="contained" color="primary">Adicionar</Button>
                </div>
                <div>
                    <List>
                        {
                            phones.map(phone => {
                                return (
                                    <ListItem>
                                        <ListItemText primary={phone} />
                                    </ListItem>
                                )
                            })
                        }
                    </List>
                </div>
            </section>

            <Button style={{ marginTop: 10 }} onClick={sendProvider} variant="contained" color="primary">Salvar</Button>
        </form>
    );

}

export default ProviderFormPage;