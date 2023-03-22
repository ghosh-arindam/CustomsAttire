import axios from "axios";
import * as types from "./actionType";

const getcustomers = (Customersdata) => ({
  type: types.GET_CUSTOMERS,
  payload: Customersdata,
});

const deletedcustomer = () => ({
  type: types.DELETE_CUSTOMER,
});

const addCustomer = (Customersdata) => ({
  type: types.ADD_CUSTOMER,
  payload: Customersdata,
});

const updateCustomer = (Customersdata) => ({
  type: types.UPDATE_CUSTOMER,
  payload: Customersdata,
});

const getSuppliers = (Suppliers) => ({
  type: types.GET_SUPPLIERS,
  payload: Suppliers,
});

const deletedSupplier = () => ({
  type: types.DELETE_SUPPLIERS,
});
const addSupplier = (Suppliersdata) => ({
  type: types.ADD_SUPPLIERS,
  payload: Suppliersdata,
});
const getpurchaseOrders = (PurchaseOrders) => ({
  type: types.GET_PURCHASEORDERS,
  payload: PurchaseOrders,
});
const addpurchaseOrders = (PurchaseOrders) => ({
  type: types.ADD_PURCHASEORDERS,
  payload: PurchaseOrders,
});
const deletedpurchaseOrders = () => ({
  type: types.ADD_PURCHASEORDERS,
});
const addproduct = (Product) => ({
  type: types.ADD_PRODUCT,
  payload: Product,
});
const getProduct = (Product) => ({
  type: types.GET_PRODUCT,
  payload: Product,
});
const getsalesOrders = (SalesOrders) => ({
  type: types.GET_SALESORDERS,
  payload: SalesOrders,
});
const addsalesOrders = (SalesOrders) => ({
  type: types.ADD_SALESORDERS,
  payload: SalesOrders,
});
const deletedsalesOrders = () => ({
  type: types.DELETE_SALESORDER,
});
export const loadCustomers = () => {
  return function (dispatch) {
    //console.log(`${process.env.REACT_APP_BASE_API_URL}/Customer`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/Customer`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getcustomers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteCustomer = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedcustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const addCustomers = (customer) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log(customer);
    axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/customer`, customer)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(addCustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const updateCustomers = (customer, id) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log("updateCustomers --->" + customer.row);
    console.log("updateCustomers" + id);
    axios
      .put(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`, customer)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateCustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};
// SUPPLIERS API CALLS
export const loadSuppliers = () => {
  return function (dispatch) {
    //console.log(`${process.env.REACT_APP_BASE_API_URL}/vendor`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/vendor`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getSuppliers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteSupplier = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/vendor/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedSupplier());
        dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};

export const addSuppliers = (supplier) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/vendor`);
    // console.log("addSuppliers--->" + supplier);
    axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/vendor`, supplier)
      .then((resp) => {
        // console.log("resp", resp);
        dispatch(addSupplier());
        dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};
export const updateSupplier = (supplier, id) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log("updateCustomers --->" + customer.row);
    console.log("updateSuppliers" + id);
    axios
      .put(`${process.env.REACT_APP_BASE_API_URL}/vendor/${id}`, supplier)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateSupplier());
        dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};
export const loadPurchaseOrders = () => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const deletePurchaseOrders = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedpurchaseOrders());
        dispatch(getpurchaseOrders());
      })
      .catch((error) => console.log(error));
  };
};

export const addPurchaseOrders = (purchaseOrder) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    console.log("addPurchaseOrders--->" + purchaseOrder);
    axios
      .post(
        `${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`,
        purchaseOrder
      )
      .then((resp) => {
        console.log("resp", resp);
        dispatch(addpurchaseOrders());
        dispatch(getpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const updatePurchaseOrders = (purchaseOrder, id) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    // console.log("updateCustomers --->" + customer.row);
    //console.log("updatePurchaseOrders" + id);
    axios
      .put(
        `${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders/${id}`,
        purchaseOrder
      )
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updatePurchaseOrders());
        dispatch(getpurchaseOrders());
      })
      .catch((error) => console.log(error));
  };
};
export const addProduct = (Product) => {
  return function (dispatch) {
    console.log(`${process.env.REACT_APP_BASE_API_URL}/Product`);
    console.log("addProduct--->" + Product);
    axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/Product`, Product)
      .then((resp) => {
        // console.log("resp", resp);
        dispatch(addproduct());
        //dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};
export const loadProduct = () => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/Product`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/Product`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getProduct(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const loadSalesOrders = () => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/Product`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getsalesOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const addSalesOrders = (salesOrder) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    console.log("addSalesOrders--->" + salesOrder);
    axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems`, salesOrder)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(addsalesOrders());
        dispatch(getsalesOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const updateSalesOrders = (salesOrder, id) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    // console.log("updateCustomers --->" + customer.row);
    //console.log("updatePurchaseOrders" + id);
    axios
      .put(
        `${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems/${id}`,
        salesOrder
      )
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateSalesOrders());
        dispatch(getsalesOrders());
      })
      .catch((error) => console.log(error));
  };
};
export const deleteSalesOrders = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedsalesOrders());
        dispatch(getsalesOrders());
      })
      .catch((error) => console.log(error));
  };
};
