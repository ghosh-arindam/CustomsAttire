import { Box, Button, MenuItem, TextField } from "@mui/material";
import { Formik } from "formik";
import * as yup from "yup";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import { useNavigate } from "react-router-dom";
import { useDispatch } from "react-redux";
import { addSuppliers } from "./../../redux/action";

const AddSupplier = () => {
  const isNonMobile = useMediaQuery("(min-width:600px)");
  const navigate = useNavigate();
  const dispatch = useDispatch();

  const handleFormSubmit = (values) => {
    //console.log(values);
    dispatch(addSuppliers(values));
    navigate("/vendor");
  };

  const preferredVendorStatus = [
    {
      value: false,
      label: "Not Preferred",
    },
    {
      value: true,
      label: "Preferred",
    },
  ];
  return (
    <Box m="20px">
      <Header title="CREATE VENDOR" subtitle="Create a New Vendor Profile" />

      <Formik
        onSubmit={handleFormSubmit}
        initialValues={initialValues}
        validationSchema={checkoutSchema}
      >
        {({
          values,
          errors,
          touched,
          handleBlur,
          handleChange,
          handleSubmit,
        }) => (
          <form onSubmit={handleSubmit} autoComplete="off">
            <Box
              display="grid"
              gap="30px"
              gridTemplateColumns="repeat(4, minmax(0, 1fr))"
              sx={{
                "& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
              }}
            >
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="Account Number"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.accountNumber}
                name="accountNumber"
                error={!!touched.accountNumber && !!errors.accountNumber}
                helperText={touched.accountNumber && errors.accountNumber}
                sx={{ gridColumn: "span 1" }}
              />

              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="Phone No"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.phoneNumber}
                name="phoneNumber"
                error={!!touched.phoneNumber && !!errors.phoneNumber}
                helperText={touched.phoneNumber && errors.phoneNumber}
                sx={{ gridColumn: "span 1.5" }}
              />
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="Vendor Name"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.vendorName}
                name="vendorName"
                error={!!touched.vendorName && !!errors.vendorName}
                helperText={touched.vendorName && errors.vendorName}
                sx={{ gridColumn: "span 2" }}
              />
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="Pan No"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.panNo}
                name="panNo"
                error={!!touched.panNo && !!errors.panNo}
                helperText={touched.panNo && errors.panNo}
                sx={{ gridColumn: "span 2" }}
              />
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="GST"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.gst}
                name="gst"
                error={!!touched.gst && !!errors.gst}
                helperText={touched.gst && errors.gst}
                sx={{ gridColumn: "span 2" }}
              />
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="Address 1"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.address1}
                name="address1"
                error={!!touched.address1 && !!errors.address1}
                helperText={touched.address1 && errors.address1}
                sx={{ gridColumn: "span 4" }}
              />
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="Address 2"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.address2}
                name="address2"
                error={!!touched.address2 && !!errors.address2}
                helperText={touched.address2 && errors.address2}
                sx={{ gridColumn: "span 4" }}
              />
              <TextField
                fullWidth
                variant="filled"
                type="text"
                label="City"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.city}
                name="city"
                error={!!touched.city && !!errors.city}
                helperText={touched.city && errors.city}
                sx={{ gridColumn: "span 2" }}
              />
              <TextField
                id="outlined-select-preferredVendorStatus"
                select
                variant="filled"
                label="Vendor Status"
                defaultValue="false"
                onBlur={handleBlur}
                onChange={handleChange}
                name="preferredVendorStatus"
                value={values.preferredVendorStatus}
                error={
                  !!touched.preferredVendorStatus &&
                  !!errors.preferredVendorStatus
                }
                helperText={
                  touched.preferredVendorStatus && errors.preferredVendorStatus
                }
                sx={{ gridColumn: "span 2" }}
              >
                {preferredVendorStatus.map((option) => (
                  <MenuItem key={option.value} value={option.value}>
                    {option.label}
                  </MenuItem>
                ))}
              </TextField>
            </Box>
            <Box display="flex" justifyContent="end" mt="20px">
              <Button type="submit" color="secondary" variant="contained">
                Create New Vendor
              </Button>
            </Box>
          </form>
        )}
      </Formik>
    </Box>
  );
};

const phoneRegExp = /^[6-9]\d{9}$/gi;
// const gstinRegExp =
//   /^[0-9]{2}[A-Z]{3}[ABCFGHLJPTF]{1}[A-Z]{1}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$/;
//const gstinRegExp = /^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$/;
const gstinRegExp = /^[\w]{15}$/;
const PanNoRegExp = /^([a-zA-Z]){5}([0-9]){4}([a-zA-Z]){1}?$/;
const checkoutSchema = yup.object().shape({
  accountNumber: yup.string().required("required"),
  vendorName: yup.string().required("required"),
  city: yup.string().required("required"),
  phoneNumber: yup
    .string()
    .matches(phoneRegExp, "Phone number is not valid")
    .required("required"),
  address1: yup
    .string()
    .test(
      "len",
      "can be empty or with string at least 2 characters and not more than 50",
      (val) => {
        if (val === undefined) {
          return true;
        }
        return val.length === 0 || (val.length >= 2 && val.length <= 50);
      }
    )
    .required("required"),
  address2: yup
    .string()
    .test(
      "len",
      "can be empty or with string at least 2 characters and not more than 50",
      (val) => {
        if (val === undefined) {
          return true;
        }
        return val.length === 0 || (val.length >= 2 && val.length <= 50);
      }
    )
    .optional(),
  panNo: yup
    .string()
    .matches(PanNoRegExp, "PAN number is not valid")
    .required("required."),
  gst: yup
    .string()
    .matches(gstinRegExp, "GSTIN number is not valid")
    .required("required"),
});
const initialValues = {
  accountNumber: "",
  vendorName: "",
  city: "",
  phoneNumber: "",
  address1: "",
  address2: "",
  panNo: "",
  gst: "",
  preferredVendorStatus: false,
};

export default AddSupplier;
