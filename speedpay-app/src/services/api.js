import Axios from "axios"
import { URL_API } from "../constants"

const getProviders = async () => {
    const providers = await Axios.get(`${URL_API}provider`);
    return providers.data;
}

const getEnterprises = async () => {
    const enterprises = await Axios.get(`${URL_API}enterprise`);
    return enterprises.data;
}

const postProvider = async (provider) => {
     await Axios.post(`${URL_API}provider`, JSON.stringify(provider));
}

export { getProviders, getEnterprises, postProvider };