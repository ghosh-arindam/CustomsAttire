import { Box, Button, TextField, Grid, MenuItem } from "@mui/material";
import { Formik } from "formik";
import * as yup from "yup";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { addProduct } from "./../../redux/action";
import { useState, useEffect } from "react";
import { loadSuppliers } from "./../../redux/action";

const PurchaseMaster = () => {
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  // const theme = useTheme();
  // const colors = tokens(theme.palette.mode);
  const navigate = useNavigate();
  const dispatch = useDispatch();
  //const [selectedVendor, setSelectedVendor] = useState("");

  const { suppliers } = useSelector((state) => state.data);

  useEffect(() => {
    dispatch(loadSuppliers());
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  // const handleVendorChange = (event) => {
  //   setSelectedVendor(event.target.value);
  // };

  const handleFormSubmit = (values) => {
    console.log(values);
    // dispatch(addProduct(values));
    //navigate("/purchaseOrders");
  };

  const fabricSchema = yup.object().shape({
    fabricCode: yup.string().required("required"),
    description: yup.string().required("required"),
    vendorName: yup.string().required("required"),
  });
  const initialValues = {
    fabricCode: "",
    description: "",
    vendorName: "",
  };
  return (
    <Grid sx={{ flexGrow: 1 }} mx={4}>
      <Header title="CREATE FABRIC" subtitle="Create a New Fabric" />
      <Formik
        onSubmit={handleFormSubmit}
        initialValues={initialValues}
        validationSchema={fabricSchema}
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
              <Box
                sx={{
                  mx: "auto",
                  p: 1,
                  mt: 1,
                  "& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
                }}
              >
                <TextField
                  id="outlined-select"
                  select
                  label="Select Vendor"
                  variant="outlined"
                  onChange={handleChange}
                  onBlur={handleBlur}
                  value={values.vendorName || ""}
                  defaultValue={"--SELECT A  VENDOR--"}
                  name="vendorName"
                  error={!!touched.vendorName && !!errors.vendorName}
                  helperText={touched.vendorName && errors.vendorName}
                  sx={{
                    align: "right",
                    minWidth: 270,
                    maxWidth: 470,
                    pt: 1,
                    "& .MuiNativeSelect-select": { pt: "8.5px" },
                  }}
                >
                  {suppliers?.map((d, index) => (
                    <MenuItem
                      key={index}
                      // value={JSON.stringify({
                      //   id: d.id,
                      //   name: d.vendorname,
                      // })}
                      value={d.vendorName}
                    >
                      {d.vendorName}
                    </MenuItem>
                  ))}
                </TextField>
              </Box>
              <TextField
                fullWidth
                variant="outlined"
                type="text"
                label="Fabric Code"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.fabricCode}
                name="fabricCode"
                error={!!touched.fabricCode && !!errors.fabricCode}
                helperText={touched.fabricCode && errors.fabricCode}
                sx={{ gridColumn: "span 4" }}
              />
              <TextField
                id="outlined-textarea"
                variant="outlined"
                type="text"
                label="Fabric Description"
                onBlur={handleBlur}
                onChange={handleChange}
                value={values.description}
                name="description"
                error={!!touched.description && !!errors.description}
                helperText={touched.description && errors.description}
                sx={{ gridColumn: "span 4" }}
                multiline
              />
            </Box>
            <Box display="flex" justifyContent="end" mt="20px">
              <Button type="submit" color="secondary" variant="contained">
                Create New Fabric
              </Button>
            </Box>
          </form>
        )}
      </Formik>
    </Grid>
  );
};

export default PurchaseMaster;
