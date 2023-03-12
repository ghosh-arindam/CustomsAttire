import { Box, Button, TextField } from "@mui/material";
import { Formik } from "formik";
import * as yup from "yup";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import { useNavigate } from "react-router-dom";
import { useDispatch } from "react-redux";
import { addProduct } from "./../../redux/action";

const PurchaseMaster = () => {
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  // const theme = useTheme();
  // const colors = tokens(theme.palette.mode);
  const navigate = useNavigate();
  const dispatch = useDispatch();

  const handleFormSubmit = (values) => {
    dispatch(addProduct(values));
    navigate("/purchaseOrders");
  };

  const fabricSchema = yup.object().shape({
    fabricCode: yup.string().required("required"),
    description: yup.string().required("required"),
  });
  const initialValues = {
    fabricCode: "",
    description: "",
  };
  return (
    <Box m="20px">
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
                value={values.address2}
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
    </Box>
  );
};

export default PurchaseMaster;
